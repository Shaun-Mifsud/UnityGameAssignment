using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePaddle : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
        float mousePos = (Input.mousePosition.y / Screen.height * 10f) - 5f;

        Vector3 paddlePosition = new Vector3(8f, this.transform.position.y, 0f);

        paddlePosition.y = Mathf.Clamp(mousePos, -5f, 5f);

        this.transform.position = paddlePosition;
    }
}
