﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Prime31.ZestKit;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnablePanels();
        }
	}

    public void DisablePanels()
    {
        Transform panels = GameObject.Find("Panels").transform;
        foreach (Transform col in panels)
        {
            foreach(Transform panel in col)
            {
                DisablePanel(panel);
            }
        }
        DisableVideo();
        EnableMainDisplay();
    }

    public void EnablePanels()
    {
        DisableMainDisplay();
        Transform panels = GameObject.Find("Panels").transform;
        foreach (Transform col in panels)
        {
            foreach (Transform panel in col)
            {
                EnablePanel(panel);
            }
        }
        EnableVideo();
    }

    void EnableMainDisplay()
    {
        LoadContent(name);
        Transform md = GameObject.Find("Main Display").transform;
        foreach (Transform child in md)
        {
            child.gameObject.SetActive(true);
            ITween<float> alphaTween = child.GetComponentInChildren<Image>().ZKalphaTo(1, 0.3f).setEaseType(EaseType.Linear);
            alphaTween.start();
        }
        Transform back = GameObject.Find("Back").transform;
        back.GetChild(0).gameObject.SetActive(true);
        ITween<float> backTween = back.GetComponentInChildren<Image>().ZKalphaTo(1, 0.3f).setEaseType(EaseType.Linear);
        backTween.start();
    }

    void DisableMainDisplay()
    {
        Transform md = GameObject.Find("Main Display").transform;
        foreach (Transform child in md)
        {
            ITween<float> alphaTween = child.GetComponentInChildren<Image>().ZKalphaTo(0, 0.3f).setEaseType(EaseType.Linear)
            .setCompletionHandler(tween =>
            {
                child.gameObject.SetActive(false);
            });
            alphaTween.start();
        }
        Transform back = GameObject.Find("Back").transform;
        ITween<float> backTween = back.GetComponentInChildren<Image>().ZKalphaTo(0, 0.3f).setEaseType(EaseType.Linear)
            .setCompletionHandler(tween =>
            {
                back.GetChild(0).gameObject.SetActive(false);
            });
        backTween.start();
    }

    void DisablePanel(Transform t)
    {
        ITween<float> alphaTween = t.GetComponent<Image>().ZKalphaTo(0, 0.3f).setEaseType(EaseType.Linear)
            .setCompletionHandler(tween =>
           {
               t.gameObject.SetActive(false);
           });
        alphaTween.start();
    }

    void EnablePanel(Transform t)
    {
        t.gameObject.SetActive(true);
        ITween<float> alphaTween = t.GetComponent<Image>().ZKalphaTo(1, 0.3f).setEaseType(EaseType.Linear);
        alphaTween.start();
    }

    void LoadContent(string project)
    {
        
        ContentLoader cl = GameObject.Find("OVRCameraRig").GetComponent<ContentLoader>();

        GameObject mainPanel = GameObject.Find("Main Display").transform.GetChild(0).GetChild(0).gameObject;
        mainPanel.GetComponent<Image>().overrideSprite = cl.mainImages[project];

        GameObject leftPanel = GameObject.Find("Main Display").transform.GetChild(1).GetChild(0).gameObject;
        leftPanel.GetComponent<Image>().overrideSprite = cl.leftImages[project];

        GameObject left2Panel = GameObject.Find("Main Display").transform.GetChild(3).GetChild(0).gameObject;
        left2Panel.GetComponent<Image>().overrideSprite = cl.left2images[project];

        GameObject left3Panel = GameObject.Find("Main Display").transform.GetChild(5).GetChild(0).gameObject;
        left3Panel.GetComponent<Image>().overrideSprite = cl.left3images[project];

        GameObject rightPanel = GameObject.Find("Main Display").transform.GetChild(2).GetChild(0).gameObject;
        rightPanel.GetComponent<Image>().overrideSprite = cl.rightImages[project];

        GameObject right2Panel = GameObject.Find("Main Display").transform.GetChild(4).GetChild(0).gameObject;
        right2Panel.GetComponent<Image>().overrideSprite = cl.right2images[project];

        GameObject right3Panel = GameObject.Find("Main Display").transform.GetChild(6).GetChild(0).gameObject;
        right3Panel.GetComponent<Image>().overrideSprite = cl.right3images[project];

    }

    void EnableVideo()
    {
        Transform vidpanel = GameObject.Find("VidPanel").transform;
        vidpanel.GetChild(0).gameObject.SetActive(true);
    }

    void DisableVideo()
    {
        Transform vidpanel = GameObject.Find("VidPanel").transform;
        vidpanel.GetChild(0).gameObject.SetActive(false);
    }

}
