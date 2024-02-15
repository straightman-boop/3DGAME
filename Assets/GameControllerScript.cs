using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    [SerializeField] int points;
    public int score;
    

    private void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 0)
        {
            //Debug.Log("RESET SCORE");
            PlayerPrefs.SetInt("score", 0);
        }

        else if(scene.buildIndex > 0)
        {
            //Debug.Log("RETREIVED SCORE");
            score = PlayerPrefs.GetInt("score", 0);
            points = score;
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0 && points == 7)
        {
            ChangeScene();
        }
    }

    public void IncrementScore()
    {
        points++;
        score = points;

        PlayerPrefs.SetInt("score", score);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
