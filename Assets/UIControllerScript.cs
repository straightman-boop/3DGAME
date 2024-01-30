using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControllerScript : MonoBehaviour
{
    [SerializeField] GameControllerScript gameControllerScript;
    public TextMeshProUGUI value;

    // Start is called before the first frame update
    void Start()
    {
        gameControllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeText()
    {
        value.text = gameControllerScript.score.ToString();
    }
}
