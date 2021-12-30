using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
public class TriggerSystem : MonoBehaviour
{
    public Timer timer;
    private void OnTriggerStay(Collider other) {
        if (other.GetComponent<OVRPlayerController>())
        {
            timer.StartTimer();
            GameObject timerTriggerEnter = GameObject.Find("TimerTriggerEnter");
            Destroy(timerTriggerEnter);
        }
    }
}
