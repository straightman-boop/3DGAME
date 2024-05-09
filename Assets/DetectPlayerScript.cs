using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerScript : MonoBehaviour
{
    public GameObject portalContainer;
    public GameObject player;

    public float spawn_Distance;

    private void Update()
    {
        float distance = Vector3.Distance(portalContainer.transform.position, player.transform.position);

        if(distance < spawn_Distance)
        {
            portalContainer.SetActive(true);
        }
    }
}
