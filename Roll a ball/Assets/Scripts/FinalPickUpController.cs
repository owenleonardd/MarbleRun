using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPickUpController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //move at constant speed until it hits a wall, then change directions:
        rb.velocity = transform.forward * speed;
    }
}
