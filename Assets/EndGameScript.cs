using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    public static EndGameScript endGameScript;

    public bool win;

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

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }

        if (win == true)
        {
            winScreen.SetActive(true);
        }

        else if (win == false)
        {
            loseScreen.SetActive(true);
        }

        Debug.Log(EndStateScript.endStateScript.endState);    
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
