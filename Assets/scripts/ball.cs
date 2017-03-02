using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(5, -20);

    void Start () {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
   
	}
	

	void Update () {
	
	}
}
