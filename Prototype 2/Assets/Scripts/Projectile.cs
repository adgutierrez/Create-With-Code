using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speedProjectile = 30.0f;
    public GameObject foodProjectile;
    public Transform projectileSpawnPoint;

    void Start()
    {
        
    }

    void Update()
    {
        // get player input
        //if (Input.GetKeyDown(KeyCode.F))
        //{
            FireProjectile();
        //}        
    }

    private void FireProjectile()
    {
        // create projectile from prefab
        //var Projectile = (GameObject)Instantiate(foodProjectile, 
        //                projectileSpawnPoint.position, projectileSpawnPoint.rotation);

        // add velocity to prefab
        transform.Translate(speedProjectile * Time.deltaTime * Vector3.forward);

        // destory projectile in 2 seconds
        // Destroy(foodProjectile, 2.0f);
    }
}
