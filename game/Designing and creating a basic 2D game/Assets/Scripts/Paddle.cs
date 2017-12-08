using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private float speed=0.35f;

	void Start () {
		
	}


    public Vector3 paddlePos;
    	
	void Update () {
        float paddleMov = transform.position.y + (Input.GetAxis("Vertical") * speed);
        paddlePos = new Vector3(-8, Mathf.Clamp(paddleMov, -5f, 5f), 0);
        gameObject.transform.position = paddlePos;
    }
}
