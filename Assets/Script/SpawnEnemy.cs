using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public GameObject enemy;

    
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawn", 2.0f, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(5, 13),1, Random.Range(-8, 8));
        Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}
