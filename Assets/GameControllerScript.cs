using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    [SerializeField] int points;
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(points == 20)
        {
            ChangeScene();
        }
    }

    public void IncrementScore()
    {
        points++;
        score = points;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
