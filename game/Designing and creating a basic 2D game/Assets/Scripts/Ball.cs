using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    float randX, randY;
    private Paddle myPaddle;
    private Vector3 paddleVector;
    private bool hasStarted;
    private Vector2 startPostion;

    private float currentSpeed = 0.0f;
    private float acc=1.0f;
    private float MaxSpeed = 100.0f;

    //starting
    void Start()
    {
        int leftscore = 0;
        int rightscore = 0;
        startPostion = GameObject.Find("ball").transform.position;

        randX = Random.Range(0f, 0.2f);
        randY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<Paddle>();
        paddleVector = this.transform.position - myPaddle.transform.position;

    }

    void Update()
    {
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        currentSpeed += acc * Time.deltaTime;

        if (currentSpeed>MaxSpeed)
        {
            currentSpeed = MaxSpeed;
        }
  
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

    

