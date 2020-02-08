using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public Player player = null;
    public Switch ammo = null;

    public Text playerHealth = null;
    public Text playerAmmo = null;
    public Text timeTime = null; 

    public float currentTime = 0f;
    public float startingTime= 10f; 



    private void Start()
    {
        currentTime = startingTime; 

    }
    void Update()
    {
        displayProperties();
        counter(); 
    }

    void displayProperties()
    {
        playerHealth.text = "Health:" +  player.health.ToString();
        playerAmmo.text = "Ammo:" + ammo.ammos.ToString(); 
    }


    void counter()
    {
        currentTime -= 1 *Time.deltaTime;
        timeTime.text = currentTime.ToString("0");    
        
        if(currentTime <= 0)
        {
            currentTime = 0; 
        }
    }

}


