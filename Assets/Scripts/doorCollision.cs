using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCollision : MonoBehaviour
{
    Rigidbody rb;
    public GameObject wlSpawnner;
    public GameObject whiteLight;
    public bool isInstantiated;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();    
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "crowbar")
        {
            Invoke("crowbarCollision", 10);
        }
        if (other.collider.tag == "key")
        {
            Invoke("keyCollision", 5);
        }
        //crowbar collides with door.
        //After 10 seconds, an event should happen.
        //The event should make the door unlocked (check the event that led to crowbar spawnning)
        //On moving outside the door, a white light should appear.
        //Walking through the light gives a feedback.
        //Feedback lets the user know that they are safe.    
    }
    private void crowbarCollision()
    {
        Destroy(GameObject.Find("crowbar"));
        rb.WakeUp();
        if (!rb.IsSleeping() && !isInstantiated)
        {
        Instantiate(whiteLight, wlSpawnner.transform);
        isInstantiated = true;
        }
    }
    private void keyCollision()
    {
        Destroy(GameObject.Find("key"));
        rb.WakeUp();
        if (!rb.IsSleeping() && !isInstantiated)
        {
        Instantiate(whiteLight, wlSpawnner.transform);
        isInstantiated = true;
        }
    }
}
