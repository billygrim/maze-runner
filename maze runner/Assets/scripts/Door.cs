using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    //public BoxCollider doorTrigger;
    bool isSteppedOn;
    bool doorOpened = false;
    public Animator anim;
    public GameObject door;

       
	void Start ()
    {
        anim = GetComponent<Animator>();
    }


    void Update ()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isSteppedOn = true;
            Debug.Log(" the trigger has been set off, door will open...");
            Destroy(door);
        }
    }
}
