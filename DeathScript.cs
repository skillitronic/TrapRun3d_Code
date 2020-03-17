using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DeathScript : MonoBehaviour
{
    public UnityEvent deathAction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            deathAction.Invoke();
        }
    }
}
