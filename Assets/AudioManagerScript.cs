using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioManagerScript audioManagerScript;

    [SerializeField] private AudioSource BG;
    [SerializeField] private AudioSource SFX;
    [SerializeField] private AudioMixer mixer;

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
        LoadAudio();
    }

    public void PickUpSFX()
    {
        SFX.Play();
    }

    private void LoadAudio()
    {
        float bgVolume = PlayerPrefs.GetFloat("BG", 1f);
        float sfxVolume = PlayerPrefs.GetFloat("SFX", 1f);
        float master = PlayerPrefs.GetFloat("Master", 1f);

        mixer.SetFloat("BG", Mathf.Log10(bgVolume) * 20);
        mixer.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
        mixer.SetFloat("Master", Mathf.Log10(master) * 20);

    }
}
