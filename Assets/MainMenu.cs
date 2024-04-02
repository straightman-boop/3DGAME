using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioManagerScript audioManagerScript;
    private void Start()
    {
        audioManagerScript = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManagerScript>();
    }

    private void Awake()
    {
        MenuManager.Init();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        MenuManager.OpenMenu(Menu.SETTINGS, gameObject);
    }

    public void Extras()
    {
        Debug.Log("The platypus (Ornithorhynchus anatinus),[3] sometimes referred to as the duck-billed platypus,[4] is a semiaquatic, egg-laying mammal endemic to eastern Australia, including Tasmania. The platypus is the sole living representative or monotypic taxon of its family Ornithorhynchidae and genus Ornithorhynchus, though a number of related species appear in the fossil record.\r\n\r\nTogether with the four species of echidna, it is one of the five extant species of monotremes, mammals that lay eggs instead of giving birth to live young. Like other monotremes, the platypus senses prey in cloudy water through electrolocation. It is one of the few species of venomous mammals, as the male platypus has a spur on the hind foot that delivers an extremely painful venom. Source: https://en.wikipedia.org/wiki/Platypus");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit >:(");
    }

    public void PressButtonSFX()
    {
        audioManagerScript.UI_SFX.Play();
    }
}
