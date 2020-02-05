﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Add myself to the Switch's Obstacles List
        GameObject.FindGameObjectWithTag("Player").GetComponent<Switch>().obstacles.Add(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("dead"); 
        }
    }
}
