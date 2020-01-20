using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject cannon;
    public Transform player;

    public float minDelay = 1.0f;
    public float maxDelay = 3.0f;

    private float lastTime = 0.0f;
    private float delayTime = 0.0f;


    void Update()
    {
        FollowPlayer();
        Shoot();
    }


    void FollowPlayer()
    {
        this.transform.LookAt(player); 
    }

    void Shoot()
    {
        if (Time.time > lastTime + delayTime)
        {
            lastTime = Time.time;

            delayTime = GetRandomValue();

            GameObject obj = Instantiate(cannon, this.transform.position, this.transform.rotation) as GameObject;

            obj.name = "cannonball"; 
        }
    }

    float GetRandomValue()
    {
        return Random.Range(minDelay, maxDelay); 
    }


    }
