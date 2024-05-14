using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndStateScript : MonoBehaviour
{
    public static EndStateScript endStateScript;

    public bool endState;

    private void Awake()
    {
        if (endStateScript == null)
        {
            endStateScript = this;

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1 && SceneManager.GetActiveScene().buildIndex != 2)
        {
            Destroy(gameObject);
        }
    }

}
