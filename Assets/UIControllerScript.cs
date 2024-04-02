using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControllerScript : MonoBehaviour
{
    [SerializeField] GameControllerScript gameControllerScript;
    public TextMeshProUGUI value;

    public GameObject settings;
    bool isDisabled = false;

    private void Awake()
    {
        value.text = gameControllerScript.score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        gameControllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
        MenuManager.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isDisabled = !isDisabled;
            settings.SetActive(isDisabled);

            if (isDisabled == true)
            {
                MenuManager.mainMenu.SetActive(true);        
                Time.timeScale = 0;
            }

            else
            {
                MenuManager.mainMenu.SetActive(false);
                MenuManager.settings.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void ChangeText()
    {
        value.text = gameControllerScript.score.ToString();
    }
}
