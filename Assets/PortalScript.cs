using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    public void SummonDemon()
    {
        GameObject spawn = Instantiate(enemy);
        spawn.transform.position = gameObject.transform.position;
    }
}
