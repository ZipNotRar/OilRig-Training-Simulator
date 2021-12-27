using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[System.Serializable]
public static class SaveSystem
{
//    public static void SavePlayer (SaveData saveData)
    public static void SavePlayer (Timer timer)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/timer.savefile";
        FileStream stream = new FileStream(path, FileMode.Create);
//        PlayerData data = new PlayerData(saveData);
        PlayerData data = new PlayerData(timer);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/timer.savefile";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Savefile not found in" + path);
            return null;
        }
        
    }
}
