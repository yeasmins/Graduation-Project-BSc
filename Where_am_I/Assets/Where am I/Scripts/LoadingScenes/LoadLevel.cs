using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
    [SerializeField] private float delaybeforeLoading = 10;
    [SerializeField] private string sceneNameToLoad;
    private float timeElapsed;


    // Calls the next scene
    private void Update () {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delaybeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }

		
	}
}
