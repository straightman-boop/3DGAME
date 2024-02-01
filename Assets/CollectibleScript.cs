using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectibleScript : MonoBehaviour
{
    public UnityEvent unityEvent;

    // Start is called before the first frame update
    void Start()
    {
        unityEvent.AddListener(GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManagerScript>().PickUpSFX);
        unityEvent.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().IncrementScore);
        unityEvent.AddListener(GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControllerScript>().ChangeText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            unityEvent.Invoke();
            Destroy(gameObject);
        }
    }
}
