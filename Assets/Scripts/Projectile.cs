using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Renderer render;
    [SerializeField] float projectileSpeed= 10f;
    [SerializeField] float projectileDamage = 10f;

    bool spriteOn = true;


    private void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Switch>().projectile.Add(this.gameObject);
    }




    private void Update()
    {
       
        Movement(); 
    }

    //private void Switch()
    //{
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        //{
        //    spriteOn = !spriteOn;
        //    gameObject.GetComponent<MeshRenderer>().enabled = spriteOn;
        //}

    //    if (Input.GetKeyDown(KeyCode.K))
    //    {
    ////        spriteOn = !spriteOn;
    ////        gameObject.GetComponent<MeshRenderer>().enabled = spriteOn;
    ////    }
    ////}


        private void Movement()
    {
        this.transform.Translate(0, 0, -projectileSpeed * Time.deltaTime);
        //this.transform.position += new Vector3(0, 0, projectileSpeed * Time.deltaTime); 
        //transform.position += transform.forward * (projectileSpeed * Time.deltaTime); 
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); 
        Debug.Log("hit"); 
    }
}




