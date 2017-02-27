﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    RigidBody 2D rigidBody;
    float speed = 5; 

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        
        var x = Input.GetAxisRaw("Horizontal"); 
        rigidBody.velocity = new Vector2(x *speed, 0); 
        
	
	}
}
