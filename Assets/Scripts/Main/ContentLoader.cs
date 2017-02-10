using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentLoader : MonoBehaviour {

    public List<Sprite> mainImageList = new List<Sprite>();
    public List<Sprite> leftImageList = new List<Sprite>();
    public List<Sprite> left2ImageList = new List<Sprite>();
    public List<Sprite> left3ImageList = new List<Sprite>();
    public List<Sprite> rightImageList = new List<Sprite>();
    public List<Sprite> right2ImageList = new List<Sprite>();
    public List<Sprite> right3ImageList = new List<Sprite>();

    public Dictionary<string, Sprite> mainImages, leftImages, rightImages, left2images, right2images, left3images, right3images;

	// Use this for initialization
	void Start () {
        mainImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", mainImageList[0] },
                {"Cisco", mainImageList[1] },
                { "Toma Leche", mainImageList[2] },
                { "Mitsubishi", mainImageList[3] },
                { "BMW", mainImageList[4] },
                { "Boardwalk", mainImageList[5] }
            };

        leftImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", leftImageList[0] },
                {"Cisco", leftImageList[1] },
                { "Toma Leche", leftImageList[2] },
                { "Mitsubishi", leftImageList[3] },
                { "BMW", leftImageList[4] },
                { "Boardwalk", leftImageList[5] }
            };

        left2images = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", left2ImageList[0] },
                { "Cisco", left2ImageList[1] },
                { "Toma Leche", left2ImageList[2] },
                { "Mitsubishi", left2ImageList[3] },
                { "BMW", left2ImageList[4] },
                { "Boardwalk", left2ImageList[5] }
            };

        left3images = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", left3ImageList[0] },
                { "Cisco", left3ImageList[1] },
                { "Toma Leche", left3ImageList[2] },
                { "Mitsubishi", left3ImageList[3] },
                { "BMW", left3ImageList[4] },
                { "Boardwalk", left3ImageList[5] }
            };

        rightImages = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", rightImageList[0] },
                {"Cisco", rightImageList[1] },
                { "Toma Leche", rightImageList[2] },
                { "Mitsubishi", rightImageList[3] },
                { "BMW", rightImageList[4] },
                { "Boardwalk", rightImageList[5] }
            };

        right2images = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", right2ImageList[0] },
                {"Cisco", right2ImageList[1] },
                { "Toma Leche", right2ImageList[2] },
                { "Mitsubishi", right2ImageList[3] },
                { "BMW", right2ImageList[4] },
                { "Boardwalk", right2ImageList[5] }
            };

        right3images = new Dictionary<string, Sprite>
            {
                { "Kanjilicious", right3ImageList[0] },
                {"Cisco", right3ImageList[1] },
                { "Toma Leche", right3ImageList[2] },
                { "Mitsubishi", right3ImageList[3] },
                { "BMW", right3ImageList[4] },
                { "Boardwalk", right3ImageList[5] }
            };
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
