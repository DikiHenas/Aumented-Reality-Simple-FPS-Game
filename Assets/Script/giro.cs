using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        player.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
    }
}
