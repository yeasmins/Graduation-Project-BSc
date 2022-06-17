using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolvePuzzle : MonoBehaviour
{
    public bool trigger = false;
    public GameObject answer;
    [SerializeField] public string sceneLoad;

    void Start()
    {
        trigger = false;
    }

    private void OnTriggerEnter(Collider answer)
    {
        answer.GetComponent<SphereCollider>().enabled = true;
        trigger = true;
    }

    private void Update()
    {
        if (trigger == true)
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
