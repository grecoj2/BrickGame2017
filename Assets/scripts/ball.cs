using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

    public Vector2 startingVelocity = new Vector2(5, -20);

    void Start () {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
   
	}
	

	void Update () {
        if (transform.position.y < -3.5f) {
            GetOut();
      
        } 
	}

    void GetOut()
    {
        Debug.Log("You are out");
    }
}
