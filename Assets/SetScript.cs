using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScript : MonoBehaviour
{

    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("hi", 78f);
    }
}
