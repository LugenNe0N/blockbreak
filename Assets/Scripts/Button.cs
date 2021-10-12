using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Button : MonoBehaviour
{
    public GameObject gameStart;
    
    public void RestartButtonPressed()
    {
        Debug.Log("Restart Button is pressed");
        SceneManager.LoadScene("main");
    }
    public void RetuenButtonPressed()
    {
        Debug.Log("Return Button is pressed");
        SceneManager.LoadScene("title");
    }
    public void StartButtonPressed()
    {
        Debug.Log("Start Button is pressed");
        SceneManager.LoadScene("main");
    }
    public void QuitButtonPressed()
    {
        Debug.Log("Quit Button is pressed");
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void GamestartButtonPressed()
    {
        gameStart.SetActive(false);
        Time.timeScale = 1f;
        
    }
}
