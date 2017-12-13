using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScore : MonoBehaviour {

    int PlayerOne_Total = level1.leftscore + level2.leftscore + level3.leftscore;
    int PlayerTwo_Total = level1.rightscore + level2.rightscore + level3.rightscore;

    void OnGUI()
    {
        GUIStyle myStyle2 = new GUIStyle();
        myStyle2.fontSize = 50;
        GUI.Label(new Rect(Screen.width / 2 - 250- 12, 200, 100, 100), "" + PlayerOne_Total, myStyle2);
        GUI.Label(new Rect(Screen.width / 2 - -250 - 12, 200, 100, 100), "" + PlayerTwo_Total, myStyle2);
    }
}
