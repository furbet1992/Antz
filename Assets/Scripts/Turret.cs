﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public int health = 100;
    public Color hitColor = Color.white;
    public Color oriColor = Color.white; 

    public GameObject cannon;
    public Transform player;

    public float minDelay = 1.0f;
    public float maxDelay = 3.0f;

    private float lastTime = 0.0f;
    private float delayTime = 0.0f;

     void Awake()
    {
        oriColor = this.GetComponent<Renderer>().material.color; 
    }

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

    // void OnTriggerEnter(Collider other)
    //{
    //    if(other.name == "magicOrb")
    //    {
    //        int hp = other.GetComponent<MagicOrb>().hitpoint;

    //        GetHealth(hp);
    //        Debug.Log("hit");
    //    }
    //}

    void GetHealth(int hp)
    {
        if (health > 0)
        {
            health -= hp;

            StartCoroutine(GetHit()); 
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator GetHit()
    {
        this.GetComponent<Renderer>().material.color = hitColor;

        yield return new WaitForSeconds(0.4f);

        this.GetComponent<Renderer>().material.color = oriColor; 
    }
}
