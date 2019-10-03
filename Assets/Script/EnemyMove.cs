using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    GameObject target;
    // Use this for initialization
    void Start () {
        target = GameObject.Find("Capsule");
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 2* Time.deltaTime);
        Destroy(this.gameObject, 6);
    }
}
