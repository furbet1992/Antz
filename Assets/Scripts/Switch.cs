﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject projectile;
    public GameObject obstacle;

    private int switchObjects = 1;

    void Start()
    {
        obstacle.GetComponent<Renderer>().enabled = true;
        projectile.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            switch (switchObjects)
            {
                case 1:   //if the obstacle is on
                    switchObjects = 2; // then the projectile will now be turned on

                    projectile.GetComponent<Renderer>().enabled = true;
                    obstacle.GetComponent<Renderer>().enabled = false;

                    break;

                case 2: //if the projectile is on

                    switchObjects = 1; // then the obstacle will be turned on

                    projectile.GetComponent<Renderer>().enabled = false;
                    obstacle.GetComponent<Renderer>().enabled = true;

                    break;
            }
        }
    }
    }
