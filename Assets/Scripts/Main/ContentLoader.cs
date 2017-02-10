using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentLoader : MonoBehaviour {

    public List<Sprite> mainImageList = new List<Sprite>();
    public List<Sprite> leftImageList = new List<Sprite>();
    public List<Sprite> rightImageList = new List<Sprite>();

    public Dictionary<string, Sprite> mainImages, leftImages, rightImages;

	// Use this for initialization
	void Start () {
        mainImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", mainImageList[0] },
                {"Cisco", mainImageList[1] },
                { "Toma Leche", mainImageList[2] },
                { "Fat Princess", mainImageList[3] },
                { "BMW", mainImageList[4] },
                { "Boardwalk", mainImageList[5] }
            };

        leftImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", leftImageList[0] },
                {"Cisco", leftImageList[1] },
                { "Toma Leche", leftImageList[2] },
                { "Fat Princess", leftImageList[3] },
                { "BMW", leftImageList[4] },
                { "Boardwalk", leftImageList[5] }
            };

        rightImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", rightImageList[0] },
                {"Cisco", rightImageList[1] },
                { "Toma Leche", rightImageList[2] },
                { "Fat Princess", rightImageList[3] },
                { "BMW", rightImageList[4] },
                { "Boardwalk", rightImageList[5] }
            };
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
