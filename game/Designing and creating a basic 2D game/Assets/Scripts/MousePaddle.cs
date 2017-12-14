using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePaddle : MonoBehaviour {


	void Start () {
		
	}
	
    //updating the paddle postion with the mouse
	void Update () {
        float mousePos = (Input.mousePosition.y / Screen.height * 10f) - 5f; //storing the location of the mouse relative to the game screen area

        Vector3 paddlePosition = new Vector3(8f, this.transform.position.y, 0f); //creating a new Vector

        paddlePosition.y = Mathf.Clamp(mousePos, -5f, 5f); //mathf.Clamp is used to limit the area in which the paddle can travel upwards and downwards

        this.transform.position = paddlePosition; //updating the new position
    }
}
