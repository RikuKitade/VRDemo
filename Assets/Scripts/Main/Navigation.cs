using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisablePanels()
    {
        Transform panels = GameObject.Find("Panels").transform;
        foreach (Transform col in panels)
        {
            foreach(Transform panel in col)
            {
                Image image = panel.GetComponent<Image>();
                image.CrossFadeAlpha(0, 0.5f, false);
            }
        }
    }
}
