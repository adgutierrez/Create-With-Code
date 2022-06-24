using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    // set rotation's speed
    public float rotationSpeed = 1000f;

    // Update is called once per frame
    void Update()
    {
        // rotate plane's propeller at a constant rate
        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
