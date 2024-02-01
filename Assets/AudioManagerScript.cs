using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource pickup;

    public void PickUpSFX()
    {
        pickup.Play();
    }
}
