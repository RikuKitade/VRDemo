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

}
