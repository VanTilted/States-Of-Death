﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public Rigidbody theRB;
    public float jumpForce;

    void Start()
    {
        theRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }

        



      
            
    }
}
