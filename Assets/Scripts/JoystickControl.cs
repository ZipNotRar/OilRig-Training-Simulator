﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JoystickControl : MonoBehaviour
{
    public Transform topOfJoystick;
    [SerializeField]
    private float forwardBackWardTilt = 0;
    [SerializeField]
    //private float sideTosideTilt = 0;
    public UnityEvent onForwardTilt;
    public UnityEvent onBackwardTilt;
    public Transform l_hand;
    public Transform r_hand;
    // Update is called once per frame
    void Start() { 
    }
    void Update()
    {
        forwardBackWardTilt = topOfJoystick.rotation.eulerAngles.x;
        if(forwardBackWardTilt < 345 && forwardBackWardTilt > 280)
        {
            forwardBackWardTilt = Mathf.Abs(forwardBackWardTilt - 360);
            onBackwardTilt.Invoke();
            Debug.Log("Backward" + forwardBackWardTilt);
        }
        else if( forwardBackWardTilt > 15 && forwardBackWardTilt < 80)
        {
            onForwardTilt.Invoke();
            Debug.Log("Forward" + forwardBackWardTilt);
        }

        // sideTosideTilt = topOfJoystick.rotation.eulerAngles.z;
        // if(sideTosideTilt < 355 && sideTosideTilt > 290)
        // {
        //     sideTosideTilt = Mathf.Abs(sideTosideTilt - 360);
        //     Debug.Log("Right" + sideTosideTilt);
        // }
        // else if(sideTosideTilt > 5 && sideTosideTilt < 74)
        // {
        //     Debug.Log("Left" + sideTosideTilt);
        // }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponentInParent<SphereCollider>())
        {
            transform.LookAt(new Vector3(l_hand.position.x ,l_hand.position.y, transform.position.z), transform.up);
            transform.LookAt(new Vector3(r_hand.position.x, r_hand.position.y, transform.position.z), transform.up);
            //transform.LookAt(other.transform.position, transform.up);
        }
    }
}
