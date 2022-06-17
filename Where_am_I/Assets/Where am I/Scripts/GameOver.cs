using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int chance = 0;
    [SerializeField] public int number; 
    public GameObject wrong1;
    public GameObject wrong2;
    public GameObject wrong3;
    [SerializeField] public string sceneName;

    void Start()
    {
        chance = 0;
    }

    private void OnTriggerEnter()
    {
        if (wrong1.GetComponent<BoxCollider>().enabled == true || wrong2.GetComponent<BoxCollider>().enabled == true 
            || wrong3.GetComponent<BoxCollider>().enabled == true)
            chance++;
    }

    void Update()
    {
        if (chance >= number)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
