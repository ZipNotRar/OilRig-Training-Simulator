﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
[System.Serializable]
public class Timer : MonoBehaviour
{
    bool stopwatchActive = false;
    public float currentTime;
    public float loadTime;
    public Text currentTimeText;
    public Text loadSavedTime;
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive)
        { 
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }
    public void StartTimer() {
        stopwatchActive = true;
    }
    public void StopTimer() {
        stopwatchActive = false;
    }
    public void SavePlayer() 
    {
        SaveSystem.SavePlayer(this);
    }
    public void  LoadPlayer()
    {
       PlayerData data = SaveSystem.LoadPlayer();
       //currentTime = data.currentIme;
       loadTime = data.currentIme;
       TimeSpan time = TimeSpan.FromSeconds(loadTime);
       loadSavedTime.text = time.ToString(@"mm\:ss\:fff");
    }
}
