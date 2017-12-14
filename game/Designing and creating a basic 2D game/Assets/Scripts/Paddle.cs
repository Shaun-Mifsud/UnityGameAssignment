using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    //setting the speed of the paddle by sotring it in a variable
    private float speed=0.35f;

	void Start () {
		
	}

   
    public Vector3 paddlePos;
    	

  
	void Update () {
        float paddleMov = transform.position.y + (Input.GetAxis("Vertical") * speed); //storing the position of the paddle times the var speed
        paddlePos = new Vector3(-8, Mathf.Clamp(paddleMov, -5f, 5f), 0); //creating a new vector where it is limiting the area in which the paddle can be moved
        gameObject.transform.position = paddlePos; //updating the new position
    }
}
