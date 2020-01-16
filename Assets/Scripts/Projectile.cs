﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Renderer render;
    [SerializeField] float projectileSpeed= 10f;
    [SerializeField] float projectileDamage;
    private Rigidbody rb; 

    


    bool spriteOn = false;

    private void Update()
    {
        Switch();
        Movement(); 
    }

    private void Switch()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            spriteOn = !spriteOn;
            gameObject.GetComponent<MeshRenderer>().enabled = spriteOn;
        }
    }

    private void Movement()
    {
        this.transform.Translate(0, 0, -projectileSpeed * Time.deltaTime);
        //this.transform.position += new Vector3(0, 0, projectileSpeed * Time.deltaTime); 
        //transform.position += transform.forward * (projectileSpeed * Time.deltaTime); 
           
        
    }
}




