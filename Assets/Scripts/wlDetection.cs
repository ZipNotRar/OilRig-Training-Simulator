using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wlDetection : MonoBehaviour
{
    public GameObject wlBox;
    private void Start() {
        this.GetComponent<Animator>().Play(0);
        wlBox.GetComponent<Animator>().Play(0);
    }
    private void OnCollisionEnter(Collision other)
    {
        this.GetComponent<Animator>().enabled = true;
        this.GetComponent<Animator>().Play(1);  
        wlBox.GetComponent<Animator>().enabled = true;
        wlBox.GetComponent<Animator>().Play(1);
    }
}
