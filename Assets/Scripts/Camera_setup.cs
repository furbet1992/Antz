using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_setup : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
 
    public Vector3 nextPosition = Vector3.zero;
 

    void Start()
    {
        //transform.LookAt(player); 
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = player.transform.position + offset;
    }
}
