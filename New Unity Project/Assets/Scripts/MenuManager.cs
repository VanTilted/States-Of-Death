using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    // Use this for initialization
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }


    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("LevelOne");
    }

}