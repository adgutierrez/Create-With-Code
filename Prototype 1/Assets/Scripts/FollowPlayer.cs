using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float xPos = 0;
    public float yPos = 10;
    public float zPos = -14;
    private Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = new Vector3(xPos, yPos, zPos);
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        // Camera will follow player with a new Vector3 position
        transform.position = player.transform.position + cameraOffset;
    }
}
