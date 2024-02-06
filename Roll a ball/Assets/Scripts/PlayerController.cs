using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Camera mainCam;
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    
    void FixedUpdate()
    {
        Vector3 forward = mainCam.transform.forward;
        forward.y = 0f;
        Vector3 right = mainCam.transform.right;
        right.y = 0f;

        // Normalize to make length one, and combine with user input
        Vector3 movement = forward.normalized * movementY + right.normalized * movementX;
        rb.AddForce(movement * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }


    }

    
    
}
