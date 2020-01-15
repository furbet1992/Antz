using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Renderer render;


    bool spriteOn = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            spriteOn = !spriteOn;
            gameObject.GetComponent<MeshRenderer>().enabled = spriteOn;      
        }


    }
}




