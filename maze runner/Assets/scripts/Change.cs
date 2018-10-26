using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Change : MonoBehaviour {

	bool isConscious;
	public Camera cam;
	public GameObject came;
	public Canvas can;

	// Use this for initialization
	void Start ()
	{
		isConscious = false;
		can.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isConscious == true)
		{
			cam.enabled = false;
			//came.SetActive(false);
			can.enabled = true;
			
			Debug.Log("knocked out");
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			isConscious = true;
			
		}
	}
}
