using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {


    public GameObject enemy;
    public List<Vector2> spawn_points = new List<Vector2>();

    

    // Use this for initialization
    void Start () {


        spawn_points.Add(new Vector2());

    }
	
	// Update is called once per frame
	void Update () {
        Vector2 spawn = new Vector2(Random.Range(-8.51f, 8.51f), 5.17f);

        GameObject obj = Instantiate(enemy, spawn, Quaternion.identity);

    }
}
