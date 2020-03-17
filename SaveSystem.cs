using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
public class SaveSystem : MonoBehaviour
{
    CoinLogic coinLogic;
    public int savedScene = 1;
    public bool[] adWatched;
    public bool[] equiped;
    public int languageSwitch;
    public void Awake()
    {
        LoadLvlData();
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            coinLogic = GameObject.Find("Player").GetComponent<CoinLogic>();
            LoadLanguageData();
            LoadCoinData();
            LoadWatchedAdData();
            LoadEquipmentData();
        }

    }

    public void SaveLvlData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Saves.bin";
        FileStream fs = new FileStream(path, FileMode.Create);
        SaveSystemData data = new SaveSystemData();
        data.nextLvl = savedScene + 1;
        bf.Serialize(fs, data);
        fs.Close();
    }
    public void LoadLvlData()
    {
        string path = Application.persistentDataPath + "/Saves.bin";
        if (File.Exists(path)){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            SaveSystemData data = (SaveSystemData)bf.Deserialize(fs);
            fs.Close();
            savedScene = data.nextLvl;
        }
    }
    public void SaveCoinsData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Saves2.bin";
        FileStream fs = new FileStream(path, FileMode.Create);
        SaveSystemData data = new SaveSystemData();
        data.coins = coinLogic.coins;
        bf.Serialize(fs, data);
        fs.Close();
    }
    public void LoadCoinData()
    {
        string path = Application.persistentDataPath + "/Saves2.bin";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            SaveSystemData data = (SaveSystemData)bf.Deserialize(fs);
            fs.Close();
            coinLogic.coins = data.coins;
        }
    }
    public void SaveWatchedAdData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Saves3.bin";
        FileStream fs = new FileStream(path, FileMode.Create);
        SaveSystemData data = new SaveSystemData();
        data.adWatched = adWatched;
        bf.Serialize(fs, data);
        fs.Close();
    }
    public void LoadWatchedAdData()
    {
        string path = Application.persistentDataPath + "/Saves3.bin";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            SaveSystemData data = (SaveSystemData)bf.Deserialize(fs);
            fs.Close();
            adWatched = data.adWatched;
        }
    }
    public void SaveEquipmentData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Saves4.bin";
        FileStream fs = new FileStream(path, FileMode.Create);
        SaveSystemData data = new SaveSystemData();
        data.equiped = equiped;
        bf.Serialize(fs, data);
        fs.Close();
    }
    public void LoadEquipmentData()
    {
        string path = Application.persistentDataPath + "/Saves4.bin";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            SaveSystemData data = (SaveSystemData)bf.Deserialize(fs);
            fs.Close();
            equiped = data.equiped;
        }
    }
    public void SaveLanguageData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Saves5.bin";
        FileStream fs = new FileStream(path, FileMode.Create);
        SaveSystemData data = new SaveSystemData();
        data.languageSwitch = languageSwitch;
        bf.Serialize(fs, data);
        fs.Close();
    }
    public void LoadLanguageData()
    {
        string path = Application.persistentDataPath + "/Saves5.bin";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            SaveSystemData data = (SaveSystemData)bf.Deserialize(fs);
            fs.Close();
            languageSwitch = data.languageSwitch;
        }
    }
}
[System.Serializable]
public class SaveSystemData
{
    public int nextLvl;
    public int coins;
    public bool[] adWatched;
    public bool[] equiped;
    public int languageSwitch;
}
