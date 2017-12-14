using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScore : MonoBehaviour {

    //adding all of the score variables used in the 3 levels into 1 variable for each player
    int PlayerOne_Total = level1.leftscore + level2.leftscore + level3.leftscore;
    int PlayerTwo_Total = level1.rightscore + level2.rightscore + level3.rightscore;


    //displaying the score of both players
    //style was added to increase the font size to 50
    void OnGUI()
    {
        GUIStyle myStyle2 = new GUIStyle();
        myStyle2.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 250- 12, 200, 100, 100), "" + PlayerOne_Total, myStyle2);
        GUI.Label(new Rect(Screen.width / 2 - -250 - 12, 200, 100, 100), "" + PlayerTwo_Total, myStyle2);
    }
}
