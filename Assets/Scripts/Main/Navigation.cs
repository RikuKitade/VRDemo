using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

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
    }

    void EnableMainDisplay()
    {
        LoadContent(name);
        Transform md = GameObject.Find("Main Display").transform;
        foreach (Transform child in md)
        {
            child.gameObject.SetActive(true);
        }
    }

    void DisableMainDisplay()
    {
        Transform md = GameObject.Find("Main Display").transform;
        foreach (Transform child in md)
        {
            child.gameObject.SetActive(false);
        }
    }

    void DisablePanel(Transform t)
    {
        t.gameObject.SetActive(false);
    }

    void EnablePanel(Transform t)
    {
        t.gameObject.SetActive(true);
    }

    void LoadContent(string project)
    {
        
        ContentLoader cl = GameObject.Find("OVRCameraRig").GetComponent<ContentLoader>();

        GameObject mainPanel = GameObject.Find("Main Display").transform.GetChild(0).GetChild(0).gameObject;
        mainPanel.GetComponent<Image>().overrideSprite = cl.mainImages[project];

        GameObject leftPanel = GameObject.Find("Main Display").transform.GetChild(1).GetChild(0).gameObject;
        leftPanel.GetComponent<Image>().overrideSprite = cl.leftImages[project];

        GameObject rightPanel = GameObject.Find("Main Display").transform.GetChild(2).GetChild(0).gameObject;
        rightPanel.GetComponent<Image>().overrideSprite = cl.rightImages[project];


    }

}
