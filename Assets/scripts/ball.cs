﻿using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(5, -20);
   
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}