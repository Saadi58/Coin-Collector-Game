using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float WaitToRestart = 1f;

    public void Gameover()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            SceneManager.LoadScene(3);
        }
    }

    public void Gamewin()
    {
        SceneManager.LoadScene(4);
    }
    public void Play()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Welcome To Level 1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Help()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Welcome To Help Menu");
    }


    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Back to Menu");
    }
    
    public void Restart() 
    {
        ScoreCount.Scorevalue = 0;
        SceneManager.LoadScene(2);
    }
}
