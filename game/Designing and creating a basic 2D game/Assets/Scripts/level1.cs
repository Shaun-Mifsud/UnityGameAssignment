﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public static int leftscore = 0;
    public static int rightscore = 0;


    void Update()
    {
        if (leftscore == 3)
        {
            NextLevel();
        }

        else if (rightscore == 3)
        {
            NextLevel();
        }
    }

    void OnCollisionEnter2D(Collision2D collName)
    {

        if (collName.gameObject.name == "LeftBorder")
        {
            leftscore++;

        }

        if (collName.gameObject.name == "RightBorder")
        {
            rightscore++;
        }
    }

/*    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);
    }
*/
    void NextLevel()
    {
        SceneManager.LoadScene("Level_2");
    }
}
