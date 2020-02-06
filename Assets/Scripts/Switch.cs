using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Switch : MonoBehaviour
{
    public List<GameObject> obstacles = new List<GameObject>();
    public List<GameObject> projectile = new List<GameObject>();
    //public GameObject projectile;
    //public GameObject obstacle;

    private int switchObjects = 1;
    public float ammos = 20f;
 
    void Start()
    {
       foreach(GameObject g in obstacles)
        {
            g.GetComponent<Renderer>().enabled = true;
        }
        foreach (GameObject p in projectile)
        {
           p.GetComponent<Renderer>().enabled = false;
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && ammos >0)
        {
            ammos -= 1; 
            switch (switchObjects)
            {

                case 1:   //if the obstacle is on
                    switchObjects = 2; // then the projectile will now be turned on

                    foreach(GameObject g in obstacles)
                    {
                        g.GetComponent<Renderer>().enabled = false;                       
                    }
                    foreach (GameObject p in projectile)
                    {
                        p.GetComponent<Renderer>().enabled = true;
                    }

                    break;

                case 2: //if the projectile is on

                    switchObjects = 1; // then the obstacle will be turned on

                    foreach (GameObject g in obstacles)
                    {
                        g.GetComponent<Renderer>().enabled = true;
                    }
                    foreach (GameObject p in projectile)
                    {
                        p.GetComponent<Renderer>().enabled = false;
                    }

                    break;
            }
            if (ammos == 0)
            {
                return;
            }
        }
    }
    }
