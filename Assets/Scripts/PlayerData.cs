using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
[System.Serializable]
public class PlayerData
{
    public float currentIme;
//    public Text savedTimeData;
//    public PlayerData (SaveData saveData)
    public PlayerData (Timer timer)    
    {
//    savedTimeData = saveData.showSavedTime;
    currentIme = timer.currentTime;
    }

}
