using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
    public static int leftscore = 0;
    public static int rightscore = 0;


    void Update()
    {
        if (leftscore == 8)
        {
            UpLevel();
        }

        else if (rightscore == 8)
        {
            UpLevel();
        }
    }

    void OnCollisionEnter2D(Collision2D collName)
    {

        if (collName.gameObject.name == "LeftBorder")
        {
            rightscore++;
        }

        if (collName.gameObject.name == "RightBorder")
        {
            leftscore++;
        }
    }

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 400 - 12, 20, 100, 100), "" + leftscore, myStyle);
        GUI.Label(new Rect(Screen.width / 2 + 400 + 12, 20, 100, 100), "" + rightscore, myStyle);
    }

    void UpLevel()
    {
        SceneManager.LoadScene("End_Screen");
    }
}