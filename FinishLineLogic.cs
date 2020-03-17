using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishLineLogic : MonoBehaviour
{
    public UnityEvent action;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            action.Invoke();
        }
    }
}
