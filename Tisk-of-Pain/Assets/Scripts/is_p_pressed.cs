using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class is_p_pressed : MonoBehaviour {

    public CameraScript c;
    public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            c.enabled = true;
            canvas.SetActive(false);

        }
	}
}
