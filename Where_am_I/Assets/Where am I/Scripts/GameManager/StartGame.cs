using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void StartTheGame()
    {
        SceneManager.LoadScene("StartScene"); // this code will load the Terrain scene.

    }
}