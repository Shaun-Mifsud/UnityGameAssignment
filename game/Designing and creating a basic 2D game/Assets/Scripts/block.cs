using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    Vector3 current_position;
    float direction = 1.0f;
    float speed = 3f;
    float heightlimit = 4f;
    float timecount = 0.0f;
    float timelimit = 0.0f;

    void Start()
    {
        current_position = this.transform.position;
    }

    void Update()
    {

        transform.Translate(0, direction * speed * Time.deltaTime * 1, 0);


        if (transform.position.y > current_position.y + heightlimit)
        {
            direction = -1;
        }
        if (transform.position.y < current_position.y)
        {
            direction = 0;
            timecount = timecount + Time.deltaTime;

            if (timecount > timelimit)
            {
                direction = 1;
                timecount = 0;
            }
        }
    }
}

