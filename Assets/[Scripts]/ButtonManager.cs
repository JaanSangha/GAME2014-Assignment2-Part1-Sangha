//PauseButtonManager.cs
//Jaan Sangha 101264598

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        Debug.Log(activeScene.name);
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnBackButtonPressed()
    {
        if( SceneManager.GetActiveScene().name == "Main" || SceneManager.GetActiveScene().name == "Instructions")
        {
            SceneManager.LoadScene("Start");
        }

        if (SceneManager.GetActiveScene().name == "Controls")
        {
            SceneManager.LoadScene("Instructions");
        }
    }

    public void OnNextButtonPressed()
    {
        if (SceneManager.GetActiveScene().name == "Instructions")
        {
            SceneManager.LoadScene("Controls");
        }
        if (SceneManager.GetActiveScene().name == "Controls")
        {
            SceneManager.LoadScene("Start");
        }
    }

    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnControlsButtonPressed()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void OnExitButtonPressed()
    {
        Application.Quit();
    }
}
