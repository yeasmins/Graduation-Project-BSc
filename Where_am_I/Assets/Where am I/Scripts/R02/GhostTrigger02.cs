using UnityEngine;
using System.Collections;
using System;

public class GhostTrigger02 : MonoBehaviour
{
    public GameObject ghost1;
    public GameObject ghost2;
    public GameObject ghost3;
    public GameObject ghost4;
    public bool played = false;
    public bool trigger = false;
    public AudioClip scareSound;

    void Start()
    {
        trigger = false;
        ghost1.GetComponent<Renderer>().enabled = false;
        ghost2.GetComponent<Renderer>().enabled = false;
        ghost3.GetComponent<Renderer>().enabled = false;
        ghost4.GetComponent<Renderer>().enabled = false;
    }

    //When player enters trigger
    void OnTriggerEnter(Collider other)
    {
        trigger = true;
    }

    void Update()
    {
        if (trigger == true)
        {
            makeScream();
            ghost1.GetComponent<Renderer>().enabled = true;
            ghost2.GetComponent<Renderer>().enabled = true;
            ghost3.GetComponent<Renderer>().enabled = true;
            ghost4.GetComponent<Renderer>().enabled = true;
        }
    }

    //sound
    void makeScream()
    {
        if (!played)
        {
            played = true;
            GetComponent<AudioSource>().PlayOneShot(scareSound);
        }
    }
}
