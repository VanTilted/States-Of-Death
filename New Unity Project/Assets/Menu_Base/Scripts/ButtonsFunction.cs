using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunction : MonoBehaviour
{

	// Use this for initialization
	public void LoadScene (int num)
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void ExitGame()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }

}
