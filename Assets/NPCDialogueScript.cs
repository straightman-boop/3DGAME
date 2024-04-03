using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogueScript : MonoBehaviour
{
    bool onceOnly = false;
    public GameObject NPCDialogueSystem;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;


    int pageTurn = 1;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Player", true);
        NPCDialogueSystem.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Player", false);
        NPCDialogueSystem.SetActive(false);
    }

    public void switchPage()
    {
        if (pageTurn == 1)
        {
            p1.SetActive(false);
            p2.SetActive(true);
            pageTurn = 2;
        }

        else if (pageTurn == 2)
        {
            p2.SetActive(false);
            p3.SetActive(true);
            pageTurn = 3;
        }

        else if (pageTurn == 3)
        {
            NPCDialogueSystem.SetActive(false);
        }
    }
}
