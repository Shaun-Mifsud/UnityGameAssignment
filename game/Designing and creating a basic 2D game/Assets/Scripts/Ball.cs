using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    static int globalLscore = 0;
    int globalRscore = 0;
    static int leftscore = 0;
    static int rightscore = 0;

    float randX, randY;
    private Paddle myPaddle;
    private Vector3 paddleVector;
    private bool hasStarted;
    private Vector2 startPostion;
    public Text LeftText;
    public Text RightText;


    //starting
    void Start()
    {
        leftscore = 0;
        rightscore = 0;

        startPostion = GameObject.Find("ball").transform.position;

        randX = Random.Range(0f, 0.2f);
        randY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<Paddle>();
        paddleVector = this.transform.position - myPaddle.transform.position;

        LeftText = GetComponent<Text>();
        RightText = GetComponent<Text>();
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

        if (colName.gameObject.name == "LeftBorder")
        {
            rightscore++;
            if (SceneManager.GetActiveScene().Equals("Level_1") && leftscore == 3 || rightscore == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (SceneManager.GetActiveScene().Equals("Level_2") && leftscore == 5 || rightscore == 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (SceneManager.GetActiveScene().Equals("Level_3") && leftscore == 8 || rightscore == 8)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                hasStarted = false;
            }
        }
        else
        {

        }
            

        if (colName.gameObject.name == "RightBorder")
        {
            leftscore++;
            if (SceneManager.GetActiveScene().Equals("Level_1") && rightscore == 3 || leftscore == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (SceneManager.GetActiveScene().Equals("Level_2") && leftscore == 5 || rightscore == 5)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            if (SceneManager.GetActiveScene().Equals("Level_3") && leftscore == 8 || rightscore == 8)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                hasStarted = false;
            }
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
