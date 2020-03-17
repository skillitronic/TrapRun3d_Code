using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyScript : MonoBehaviour
{
    SaveSystem saveSystem;
    CoinLogic coinLogic;
    public void Awake()
    {
        saveSystem = GameObject.Find("GameManager").GetComponent<SaveSystem>();
        coinLogic = GameObject.Find("GameManager").GetComponent<CoinLogic>();
    }
    public void Buy()
    {
        this.gameObject.SetActive(false);
        int b = int.Parse(this.gameObject.name);
        saveSystem.adWatched[b] = true;
    }
    public void BuyWithShards()
    {
        if (coinLogic.coins >= 500)
        {
            coinLogic.coins -= 500;
            this.gameObject.SetActive(false);
            int b = int.Parse(this.gameObject.name);
            saveSystem.adWatched[b] = true;
            saveSystem.SaveWatchedAdData();
            saveSystem.SaveCoinsData();
        }
    }
}
