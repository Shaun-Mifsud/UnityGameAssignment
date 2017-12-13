using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    int leftscore = 0;
    int rightscore = 0;

    float randX, randY;
    private Paddle myPaddle;
    private Vector3 paddleVector;
    private bool hasStarted;
    private Vector2 startPostion;

    //starting
    void Start()
    {

        startPostion = GameObject.Find("ball").transform.position;

        randX = Random.Range(0f, 0.2f);
        randY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<Paddle>();
        paddleVector = this.transform.position - myPaddle.transform.position;

    }

    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = myPaddle.transform.position + paddleVector;

            if (Input.GetKeyDown("space"))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(15f, 5f);
            }
        }
    }

 
    

    void OnCollisionEnter2D(Collision2D colName)
    {
        if (colName.gameObject.name == "LeftBorder" || colName.gameObject.name == "RightBorder")
        {
            hasStarted = false;
        }

            if (colName.gameObject.name == "TopBorder" || colName.gameObject.name == "bottomBorder")
        {
            randX = Random.Range(-0.2f,0f);
            Vector2 tweak = new Vector2(randY,randX);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }

        if (colName.gameObject.name == "LeftPaddle" || colName.gameObject.name == "RightPaddle")
        {
            randX = Random.Range(-0.2f, 0f);
            randY = Random.Range(0f,-0.2f);
            Vector2 tweak = new Vector2(randY, randX);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}

    

