using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadR00 : MonoBehaviour
{
    public GameObject player;
    public bool trigger = false;

    void Start()
    {
        trigger = false;
    }

    private void OnTriggerEnter(Collider player)
    {
        player.GetComponent<SphereCollider>().enabled = true;
        trigger = true;
    }

    private void Update()
    {
        if (trigger == true)
        {
            SceneManager.LoadScene("LoadR00");
        }
    }

}
