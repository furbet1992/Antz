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

    // Update is called once per frame
    void Update()
    {
        displayProperties(); 
    }

    void displayProperties()
    {
        playerHealth.text = "Health:" +  player.health.ToString();
        playerAmmo.text = "Ammo:" + ammo.ammos.ToString(); 
    }

}
