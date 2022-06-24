using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    public float xPos = 0;          // variable to store vector3 x position
    public float yPos = 10;         // variable to store vector3 yx position
    public float zPos = -14;        // variable to store vector3 z position
    private Vector3 cameraOffset;   // variable to store all vector3 positions

    void Start()
    {
        // set camera's offset to a vector 3 position (x, y, z)
        cameraOffset = new Vector3(xPos, yPos, zPos);
    }

    void LateUpdate()
    {
        // Camera position = player position plus cameraOffset
        transform.position = player.transform.position + cameraOffset;
    }


}
