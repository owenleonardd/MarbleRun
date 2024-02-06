using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Win"))
        {
            winTextObject.SetActive(true);
        }
    }
}
