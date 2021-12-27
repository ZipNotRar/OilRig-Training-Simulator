using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class SaveData : MonoBehaviour
{
    public Text saveTimeBox;

    public Text showSavedTime;
    //public Text loadSavedTime;
    public void clickSaveButton()
    {
        PlayerPrefs.SetString("savedTime", saveTimeBox.text);
        Debug.Log("The saved time is " + PlayerPrefs.GetString("savedTime"));
    }
    // public void SavePlayer()
    // {
    //     SaveSystem.SavePlayer(this);        
    // } 
    public void showSaveData()
    {
       showSavedTime.text = PlayerPrefs.GetString("savedTime");
    }
    // public void LoadPlayer()
    // {
    //    PlayerData data = SaveSystem.LoadPlayer();
    //    loadSavedTime = data.savedTimeData;     
    // }
}
