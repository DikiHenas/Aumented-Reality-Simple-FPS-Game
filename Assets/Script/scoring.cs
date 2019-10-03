using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {
    public static int score = 0;
    private Text label;
    // Use this for initialization
    void Start () {
        label = GameObject.Find("Score").GetComponent<Text>();
        label.text = " ";
    }
	
	// Update is called once per frame
	void Update () {
        label.text = "Score:" + score;
	}
}
