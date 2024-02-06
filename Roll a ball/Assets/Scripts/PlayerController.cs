using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public int PickUpAmount;
    [HideInInspector]public Boolean allCollected = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= PickUpAmount)
        {
            allCollected = true;
            winTextObject.SetActive(true);
        }
    }
    
}
