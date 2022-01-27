using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OVR;
public class TriggerSystem : MonoBehaviour
{
    public Timer timer;
    public SaveData saveData;
    public TMPro.TMP_Text tempReadings;
    public PhysicsButton physicsButton;
    public GameObject rw1;
    public GameObject rw2;
    public GameObject rw6;
    public GameObject alarm;
    public GameObject pipeB;
    public GameObject rw5;
    public GameObject whiteLight;
    public GameObject crowbar;
    public GameObject key;
    public GameObject cbSpawnner;
    public GameObject keySpawnner;
    public bool isInstantiated;
    private void Start() {
        physicsButton.GetComponent<PhysicsButton>();
    }
    private void OnTriggerStay(Collider other) {
        if (other.GetComponent<OVRPlayerController>() && tempReadings.text == "612 °C" && tempReadings.tag == "TempHigh")
        {
            timer.StartTimer();
        }
        if (other.GetComponent<OVRPlayerController>() && rw1.tag == "rw1")
        {
            timer.StopTimer();
            saveData.clickSaveButton();
            saveData.showSaveData();
            timer.SavePlayer();
            timer.LoadPlayer();
            tempReadings.tag = "Untagged";
        }
        if (other.GetComponent<OVRPlayerController>() && rw2.tag == "rw2")
        {
            timer.StartTimer();
        }
        if (other.GetComponent<OVRPlayerController>() && alarm.tag == "fireAlarmTag")
        {
            timer.StopTimer();
            saveData.clickSaveButton();
            saveData.showSaveData();
            timer.SavePlayer();
            timer.LoadPlayer();
            alarm.tag = "Untagged";
            rw2.tag = "Untagged";
        }

        if (other.GetComponent<OVRPlayerController>() && rw6.tag == "rw6")
        {
            timer.StartTimer();
        }
        if (other.GetComponent<OVRPlayerController>() && pipeB.tag == "Pipe_B")
        {
            timer.StopTimer();
            saveData.clickSaveButton();
            saveData.showSaveData();
            timer.SavePlayer();
            timer.LoadPlayer();
            pipeB.tag = "Untagged";
            rw6.tag = "Untagged";
        }
        if (other.GetComponent<OVRPlayerController>() && rw5.tag == "rw5")
        {
            timer.StartTimer();
        }
        if (other.GetComponent<OVRPlayerController>() && whiteLight.activeSelf == true)
        {
            Debug.Log("stopwatch stops here");
        }
    }

    public void doorUnlockFunction() 
    {
        if (!isInstantiated)
        {
        Instantiate(crowbar, cbSpawnner.transform);
        Instantiate(key, keySpawnner.transform);
        isInstantiated = true;
        }
    }
    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.GetComponent<OVRPlayerController>())
    //     {
    //         timer.StopTimer();
    //         saveData.clickSaveButton();
    //         saveData.showSaveData();
    //         timer.SavePlayer();
    //         timer.LoadPlayer();
    //         // bool isStopTimerEnabled = true;
    //         // bool isSavePlayerEnabled = true;
    //         // if (isStopTimerEnabled)
    //         // {
    //         // timer.SavePlayer();

    //         // }
    //         // if (isSavePlayerEnabled)
    //         // {timer.LoadPlayer();
    //         // }
    //     }
    // }
}
