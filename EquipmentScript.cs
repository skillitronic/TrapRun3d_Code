using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EquipmentScript : MonoBehaviour
{
    public UnityEvent card0, card1, card2, card3, card4, card5, card6, card7, card8, card9, card10, card11;
    GameObject gameManager;
    delegate void SpawnRocksMethod();
    List<SpawnRocksMethod> SetCharacter = new List<SpawnRocksMethod>();
    public void CreateList()
    {
        SetCharacter.Add(EquipCard0);
        SetCharacter.Add(EquipCard1);
        SetCharacter.Add(EquipCard2);
        SetCharacter.Add(EquipCard3);
        SetCharacter.Add(EquipCard4);
        SetCharacter.Add(EquipCard5);
        SetCharacter.Add(EquipCard6);
        SetCharacter.Add(EquipCard7);
        SetCharacter.Add(EquipCard8);
        SetCharacter.Add(EquipCard9);
        SetCharacter.Add(EquipCard10);
        SetCharacter.Add(EquipCard11);
    }
    private void Awake()
    {
        CreateList();
        gameManager = GameObject.Find("GameManager");
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            if (gameManager.GetComponent<SaveSystem>().equiped[i] == true)
            {
                SetCharacter[i]();
            }
        }
    }
    public void EquipCard0()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[0] = true;
        card0.Invoke();
    }
    public void EquipCard1()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[1] = true;
        card1.Invoke();
    }
    public void EquipCard2()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[2] = true;
        card2.Invoke();
    }
    public void EquipCard3()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[3] = true;
        card3.Invoke();
    }
    public void EquipCard4()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[4] = true;
        card4.Invoke();
    }
    public void EquipCard5()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[5] = true;
        card5.Invoke();
    }
    public void EquipCard6()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[6] = true;
        card6.Invoke();
    }
    public void EquipCard7()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[7] = true;
        card7.Invoke();
    }
    public void EquipCard8()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[8] = true;
        card8.Invoke();
    }

    public void EquipCard9()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[9] = true;
        card9.Invoke();
    }
    public void EquipCard10()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[10] = true;
        card10.Invoke();
    }
    public void EquipCard11()
    {
        for (int i = 0; i < gameManager.GetComponent<SaveSystem>().equiped.Length; i++)
        {
            gameManager.GetComponent<SaveSystem>().equiped[i] = false;
        }
        gameManager.GetComponent<SaveSystem>().equiped[11] = true;
        card11.Invoke();
    }
}
