using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float horizontalMax = 20;
    public float verticalMax = 8;
    public float playerMoveSpeed = 10;
    public float speedProjectile = 30.0f;

    public GameObject foodProjectile;

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

        if (transform.position.z < -verticalMax )
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -verticalMax);
        }

        if (transform.position.z > verticalMax )
        {
            transform.position= new Vector3(transform.position.x, transform.position.y, verticalMax);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(playerMoveSpeed * horizontalInput * Time.deltaTime * Vector3.right);
        transform.Translate(playerMoveSpeed * verticalInput * Time.deltaTime * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(foodProjectile, transform.position, transform.rotation);
        }
    }
}