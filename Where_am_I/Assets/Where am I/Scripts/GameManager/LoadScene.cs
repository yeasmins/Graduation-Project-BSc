﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName; 

    public void LoadTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
