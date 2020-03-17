using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLogic : MonoBehaviour
{

    public GameObject[] cells;
    SaveSystem saveSystem;
    public void Awake()
    {
        saveSystem = GetComponent<SaveSystem>();
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].transform.GetChild(2).name = "" + i;
            if (saveSystem.adWatched[i] == true)
            {
                cells[i].transform.GetChild(2).gameObject.SetActive(false);
            }
            print("at " + i);
        }
        print("Done");
    }
}