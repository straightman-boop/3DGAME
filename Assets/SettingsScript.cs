using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] Slider BG;
    [SerializeField] Slider SFX;
    [SerializeField] Slider Etc;
    [SerializeField] Slider Master;

    [SerializeField] AudioMixer mixer;


    // Start is called before the first frame update
    void Start()
    {
        BG.value = PlayerPrefs.GetFloat("BG", 1f);
        SFX.value = PlayerPrefs.GetFloat("SFX", 1f);
        Etc.value = PlayerPrefs.GetFloat("etc", 1f);
        Master.value = PlayerPrefs.GetFloat("Master", 1f);

    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("BG", BG.value);
        PlayerPrefs.SetFloat("SFX", SFX.value);
        PlayerPrefs.SetFloat("etc", Etc.value);
        PlayerPrefs.SetFloat("Master", Master.value);


        //Debug.Log("Settings Saved");

    }

    public void Slider_Master()
    {
        mixer.SetFloat("Master", Mathf.Lerp(-80f, 0f, Master.value));

    }
    public void Slider_SFX()
    {
        mixer.SetFloat("SFX", Mathf.Lerp(-80f, 0f, SFX.value));

    }
    public void Slider_BG()
    {
        mixer.SetFloat("BG", Mathf.Lerp(-80f, 0f, BG.value));
    }

    public void Slider_etc()
    {
        mixer.SetFloat("UI_SFX", Mathf.Lerp(-80f, 0f, Etc.value));
    }

    /*Fish Eggs; Fish; Fish Feed; Cleaner(Pool Net + Empty Container); Money; Repair Kits;*/

}
