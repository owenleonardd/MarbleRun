using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreatePickUp : MonoBehaviour
{
    public GameObject PickUp;
    public GameObject finalPickUp;
    public int PickUpAmount;
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    public GameObject player;
    private PlayerController pc;
    
    

    // Start is called before the first frame update
    void Start()
    {
        pc = player.GetComponent<PlayerController>();
        for (int i = 0; i < PickUpAmount; i++)
        {
            Vector3 position = new Vector3(Random.Range(xMin, xMax), 0.5f, Random.Range(zMin, zMax));
            Instantiate(PickUp, position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if (pc.allCollected)
        {
            pc.allCollected = false;
            Instantiate(finalPickUp, new Vector3(0, 0.5f, 0), Quaternion.identity);
        }
    }
}
