using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float rotationalSpeed = 50f;

    bool buttonPressed = true; 

    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();


    }

    private void Move()
    {
        
        {     
            this.transform.Translate(0f, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (buttonPressed)
            {
                transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
                transform.Rotate(transform.up * rotationalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
             transform.position = transform.position + new Vector3(-speed * Time.deltaTime, 0, 0);
             transform.Rotate(transform.up * -rotationalSpeed);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacles")
        {
            Destroy(gameObject);   //gameover, you lose 
            Debug.Log("hit"); 
        }
    }

}


