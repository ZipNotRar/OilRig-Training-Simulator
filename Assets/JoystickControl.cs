using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControl : MonoBehaviour
{
    public Transform topOfJoystick;
    [SerializeField]
    private float forwardBackWardTilt = 0;
    [SerializeField]
    private float sideTosideTilt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardBackWardTilt = topOfJoystick.rotation.eulerAngles.x;
        if(forwardBackWardTilt < 355 && forwardBackWardTilt > 290)
        {
            forwardBackWardTilt = Mathf.Abs(forwardBackWardTilt - 360);
            Debug.Log("Backward" + forwardBackWardTilt);
        }
        else if( forwardBackWardTilt > 5 && forwardBackWardTilt < 74)
        {
            Debug.Log("Forward" + forwardBackWardTilt);
        }

        sideTosideTilt = topOfJoystick.rotation.eulerAngles.z;
        if(sideTosideTilt < 355 && sideTosideTilt > 290)
        {
            sideTosideTilt = Mathf.Abs(sideTosideTilt - 360);
            Debug.Log("Right" + sideTosideTilt);
        }
        else if(sideTosideTilt > 5 && sideTosideTilt < 74)
        {
            Debug.Log("Left" + sideTosideTilt);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponentInParent<SphereCollider>())
        {
            transform.LookAt(other.transform.position, transform.up);
        }
    }
}
