using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Timeline;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript audioManagerScript;

    [SerializeField] private AudioSource BG;
    [SerializeField] private AudioSource SFX;
    [SerializeField] private AudioMixer mixer;
    [SerializeField] public AudioSource UI_SFX;

    private void Start()
    {
        //mixer.SetFloat("BG", Mathf.Log10(PlayerPrefs.GetFloat("BG", 1f)) * 20);
        //mixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("SFX", 1f)) * 20);
        //mixer.SetFloat("Master", Mathf.Log10(PlayerPrefs.GetFloat("Master", 1f)) * 20);  

        float bgVolume = PlayerPrefs.GetFloat("BG", 1f);
        float sfxVolume = PlayerPrefs.GetFloat("SFX", 1f);
        float master = PlayerPrefs.GetFloat("Master", 1f);
        float uisfx = PlayerPrefs.GetFloat("etc", 1f);

        mixer.SetFloat("BG", Mathf.Lerp(-80f, 0f, bgVolume));
        mixer.SetFloat("SFX", Mathf.Lerp(-80f, 0f, sfxVolume));
        mixer.SetFloat("Master", Mathf.Lerp(-80f, 0f, master));
        mixer.SetFloat("etc", Mathf.Lerp(-80f, 0f, uisfx));

    }

    private void Awake()
    {
        if (audioManagerScript == null)
        {
            audioManagerScript = this;

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
        //LoadAudio();
    }

    private void Update()
    {
        //Debug.Log("BG: " + PlayerPrefs.GetFloat("BG"));
        //Debug.Log("SFX: " + PlayerPrefs.GetFloat("SFX"));
        //Debug.Log("Master: " + PlayerPrefs.GetFloat("Master"));

        //Debug.Log(PlayerPrefs.GetInt("score", 0));

    }

    //private void LoadAudio()
    //{
    //    float bgVolume = PlayerPrefs.GetFloat("BG", 1f);
    //    float sfxVolume = PlayerPrefs.GetFloat("SFX", 1f);
    //    float master = PlayerPrefs.GetFloat("Master", 1f);

    //    mixer.SetFloat("BG", Mathf.Log10(bgVolume) * 20);
    //    mixer.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
    //    mixer.SetFloat("Master", Mathf.Log10(master) * 20);

    //    Debug.Log("audioSettingsloaded");

    //}

    public void PickUpSFX()
    {
        SFX.Play();
    }

}
