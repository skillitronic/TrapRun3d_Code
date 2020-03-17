using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private int playerSpeed;
    private bool isClickedToStop = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (isClickedToStop == false)
            rb.velocity = new Vector3(0, 0, playerSpeed);
    }
    public void StopMovementOnClick()
    {
        isClickedToStop = true;
        rb.velocity = Vector3.zero;
    }
    public void ContinueMovement()
    {
        isClickedToStop = false;
    }
    public void Shift5f()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 5f);
    }
}
