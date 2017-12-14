using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    //Switch scene indicated by the parameter when 'Start' button is pressed
    public void NextScene(string sceneSwitch)
    {
        SceneManager.LoadScene(sceneSwitch);
    }

    //exiting the game when 'Quit' button is pressed
    public void exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
