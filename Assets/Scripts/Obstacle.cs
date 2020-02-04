using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Add myself to the Switch's Obstacles List
        GameObject.FindGameObjectWithTag("Player").GetComponent<Switch>().obstacles.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
