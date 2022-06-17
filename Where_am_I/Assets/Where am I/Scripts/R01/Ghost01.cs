using UnityEngine;
using System.Collections;
using System;

public class Ghost01 : MonoBehaviour
{
    [SerializeField] private float delaybeforeLoading = 5f;
    private float timeElapsed=2f;
    public GameObject scare;
    public bool played = false;
    public AudioClip scareSound;

    void Start()
    {
        scare.GetComponent<Renderer>().enabled = false;
    }

    //timer
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delaybeforeLoading)
        {
            scare.GetComponent<Renderer>().enabled = true;
            makeHimScream();
        }

    }

    //sound
    void makeHimScream()
    {
        if (!played)
        {
            played = true;
            GetComponent<AudioSource>().PlayOneShot(scareSound);
        }
    }
}
