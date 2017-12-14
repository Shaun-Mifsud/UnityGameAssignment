using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block2 : MonoBehaviour
{
    //Declaring variables
    Vector3 current_position;
    float direction = -1.0f;
    float speed = 3f;
    float heightlimit = -4f;
    float timecount = 0.0f;
    float timelimit = 0.0f;

    void Start()
    {
        //getting current position of the moving block
        current_position = this.transform.position;
    }

    void Update()
    {

        transform.Translate(0, direction * speed * Time.deltaTime * 1, 0);

        //when the updated position of the block is greater than the starting postion + var heightlimit the direction is reversed 
        if (transform.position.y < current_position.y + heightlimit)
        {
            direction = -1;
        }
        //once on the original position the block moves again downwards
        if (transform.position.y > current_position.y)
        {
            direction = 0;
            timecount = timecount + Time.deltaTime;

            //checking when swithing directions
            if (timecount > timelimit)
            {
                direction = 1;
                timecount = 0;
            }
        }
    }
}

