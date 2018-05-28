﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport_script : MonoBehaviour
{

    public float speed = 0.9f;
    public Vector3 startpos;
    public Vector3 endpos;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Teleporting Sphere

    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "teleport_platform") //When the "Sphere" object collides with "teleport_platform" object in Teleport_Box the Ball teleports above the ramp. 
        {
            transform.position = Vector3.Lerp(endpos, startpos, speed * Time.deltaTime);
        }
    }
}