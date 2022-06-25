using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float horizontalMax = 20;
    public float verticalMax = 10;
    public float moveSpeed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x < -horizontalMax )
        {
            transform.position = new Vector3(-horizontalMax, transform.position.y, transform.position.z);
        }

        if (transform.position.x > horizontalMax )
        {
            transform.position = new Vector3(horizontalMax, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(moveSpeed * horizontalInput * Time.deltaTime * Vector3.right);
        transform.Translate(moveSpeed * verticalInput * Time.deltaTime * Vector3.forward);
    }
}
