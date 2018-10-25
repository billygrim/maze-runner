using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour {

    // public GameObject trapPrefab;
    public Trap trap;
    bool trapActivated;
  //  public GameObject playerObj;

 
    void Start()
    {
        trapActivated = false;
    }
	

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");


        if (other.CompareTag("Player"))
        {
            trapActivated = true;
            Debug.Log(" Trigger Has Been Set Off");

            Instantiate(trap.prefab, transform.position, Quaternion.identity);
            Debug.Log(" player has taken hectic amount of damage");

           // Destroy(playerObj);
        }
    }
}
