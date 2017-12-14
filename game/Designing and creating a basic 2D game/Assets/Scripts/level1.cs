using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    //Declaring both players variables 
    public static int leftscore = 0;
    public static int rightscore = 0;


    //resetting the score
    void Start()
    {
        leftscore = 0;
        rightscore = 0;
    }


    //checking if one of the scores are eqaul to 3
    //when either leftscore or rightscore  is equal to 3, NextLevel function is called
    private void Update()
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


    //When ball hits left border, rightscore variable is increased by 1
    void OnCollisionEnter2D(Collision2D collName)
    {

        if (collName.gameObject.name == "LeftBorder")
        {
            rightscore++;

        }
        //When ball hits right border, leftscore variable is increased by 1
        if (collName.gameObject.name == "RightBorder")
        {
            leftscore++;
        }

        
    }


    //displaying the score of both players in level 1
    void OnGUI()
    {
        GUIStyle myStyle1 = new GUIStyle();
        myStyle1.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 400 - 12, 20, 100, 100), "" + leftscore, myStyle1);
        GUI.Label(new Rect(Screen.width / 2 + 400 + 12, 20, 100, 100), "" + rightscore, myStyle1);

    }

    //loads next scene (Level_1) when this function is called
    void NextLevel()
    {
        SceneManager.LoadScene("Level_2");
    }
}
