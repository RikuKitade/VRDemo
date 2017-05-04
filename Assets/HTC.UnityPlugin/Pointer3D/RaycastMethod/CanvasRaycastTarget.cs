﻿//========= Copyright 2016, HTC Corporation. All rights reserved. ===========

using UnityEngine;
using UnityEngine.EventSystems;

namespace HTC.UnityPlugin.Pointer3D
{
    public interface ICanvasRaycastTarget
    {
        Canvas canvas { get; }
        bool enabled { get; }
        bool ignoreReversedGraphics { get; }
    }

    [AddComponentMenu("HTC/Pointer3D/Canvas Raycast Target")]
    [RequireComponent(typeof(Canvas))]
    [DisallowMultipleComponent]
    public class CanvasRaycastTarget : UIBehaviour, ICanvasRaycastTarget
    {
        private Canvas m_canvas;
        [SerializeField]
        private bool m_IgnoreReversedGraphics = true;

        public virtual Canvas canvas { get { return m_canvas ?? (m_canvas = GetComponent<Canvas>()); } }

        public bool ignoreReversedGraphics { get { return m_IgnoreReversedGraphics; } set { m_IgnoreReversedGraphics = value; } }

        protected override void OnEnable()
        {
            base.OnEnable();
            CanvasRaycastMethod.AddTarget(this);
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            CanvasRaycastMethod.RemoveTarget(this);
        }
    }
}