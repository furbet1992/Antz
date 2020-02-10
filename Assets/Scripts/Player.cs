using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health = 100f; 
    public float speed = 10;
    public float rotationalSpeed = 50f;
    public float jumpForce = 10f;

    public Text healthText;

    public GameManager gameManager; 

    bool buttonPressed = true;
    bool grounded = true;

    Rigidbody rb;
    Projectile projectile;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        healthText = GetComponent<Text>(); 
    }


    void Update()
    {
        Move();
        Health(); 
    }


    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jump");
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }

        {
            transform.Translate(0f, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
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
                     if (other.tag == "Obstacles") 
                {
                    health -= 70; 
                }

                    if (other.tag == "Projectile")
                {
                    health -= 50;
                }


                    if(other.tag == "SpeedBoost")
                 {
                     speed += 20; 
                 }
            }

    void Health()
    {
        if (health <= 0 || gameManager.currentTime == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
            Destroy(gameObject); // add canvas 'DEAD'
        }
    }
}

   



    


