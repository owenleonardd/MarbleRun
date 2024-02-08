using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float speed = 1.0f;

    public float targetX, targetY, targetZ;
    private Vector3 startPosition;

    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        targetPosition = new Vector3(targetX, targetY, targetZ);
        
    }
    
    
private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(startPosition, targetPosition, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
