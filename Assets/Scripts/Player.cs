using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public float rotationalSpeed = 50f;

    bool buttonPressed = true; 

    public Rigidbody rb;
    public float jumpForce = 10f;
    bool grounded = true; 


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Move();
        Jump();


    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jump");  
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        }
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


