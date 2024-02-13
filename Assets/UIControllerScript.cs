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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isDisabled = !isDisabled;
            settings.SetActive(isDisabled);
        }
    }

    public void ChangeText()
    {
        value.text = gameControllerScript.score.ToString();
    }
}
