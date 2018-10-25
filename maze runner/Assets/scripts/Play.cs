﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    public Camera cam;
    public float speed = 2f;
    public float rotationSpeed;
    public float sprint = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal= Input.GetAxis("Horizontal");
        float veritcal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, veritcal);
        Vector3 rotation = new Vector3(0, horizontal, 0);

        transform.Translate(movement * Time.deltaTime * speed);
        transform.Rotate(rotation * Time.deltaTime * rotationSpeed);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprint;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2f;
        }
	}

}
