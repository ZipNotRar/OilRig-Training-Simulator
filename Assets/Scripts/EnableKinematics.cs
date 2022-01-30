using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableKinematics : MonoBehaviour
{
    public GameObject door;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "crowbar")
        {
            rb.isKinematic = true;
        }    
    }
}
