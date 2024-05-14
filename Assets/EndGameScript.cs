using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class EndGameScript : MonoBehaviour
{
    public static EndGameScript endGameScript;

    int totalScore;

    private void Awake()
    {
        if (endGameScript == null)
        {
            endGameScript = this;

            DontDestroyOnLoad(gameObject);
        }
       

        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject winScreen;
    public GameObject loseScreen;

    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("score", 0);
    }

    private void Update()
    {
        //win = EndStateScript.endStateScript.endState;

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }

        if (totalScore == 15)
        {
            winScreen.SetActive(true);
            loseScreen.SetActive(false);
        }

        else if (totalScore < 15)
        {
            loseScreen.SetActive(true);
            winScreen.SetActive(false);
        }
   
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
