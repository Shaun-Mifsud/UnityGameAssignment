using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour
{
    public static int leftscore = 0;
    public static int rightscore = 0;

    void Start()
    {
        leftscore = 0;
        rightscore = 0;
    }

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
        GUIStyle myStyle1 = new GUIStyle();
        myStyle1.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 400 - 12, 20, 100, 100), "" + leftscore, myStyle1);
        GUI.Label(new Rect(Screen.width / 2 + 400 + 12, 20, 100, 100), "" + rightscore, myStyle1);

    }

    void NextLevel()
    {
        SceneManager.LoadScene("Level_2");
    }
}
