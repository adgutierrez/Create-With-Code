using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperBounds = 30.0f;
    public float lowerBounds = -15;
    
    public float leftBounds = -20;
    public float rightBounds = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBounds || transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.x < leftBounds || transform.position.x > rightBounds)
        {
            Destroy(gameObject);
        }
    }
}
