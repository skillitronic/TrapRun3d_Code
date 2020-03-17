using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinLogic : MonoBehaviour
{
    public int coins;
    public Text mainMenuShardCounterText;
    public Text gamePlayShardCounterText;
    public AudioSource shardSound;
    private void Start()
    {
        mainMenuShardCounterText.text = "" + coins;
        gamePlayShardCounterText.text = "" + coins;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shard"))
        {
            Destroy(other.gameObject);
            coins++;
            gamePlayShardCounterText.text = "" + coins;
            shardSound.Play();
        }
    }
}
