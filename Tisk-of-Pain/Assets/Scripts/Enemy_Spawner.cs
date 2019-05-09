using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

    float timeLeft = 0f;
    public GameObject enemy;
    public List<Vector2> spawn_points = new List<Vector2>();

    

    // Use this for initialization
    void Start () {


        ;

    }
	
	// Update is called once per frame
	void Update () {
        

        timeLeft += Time.deltaTime;
        if (timeLeft >= 3f)
        {

            Vector2 spawn = new Vector2(50,-2.76f);

            GameObject obj = Instantiate(enemy, spawn, Quaternion.identity);

            timeLeft = 0f;

            

        }
        
        if (timeLeft >= 4f)
        {

            Vector2 spawn2 = new Vector2(50.6f,24.16f );

            GameObject obj = Instantiate(enemy, spawn2, Quaternion.identity);

            timeLeft = 0f;



        }

    }
}
