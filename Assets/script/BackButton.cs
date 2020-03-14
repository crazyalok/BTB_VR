using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    int sceneIndex;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (sceneIndex > 0)
                SceneManager.LoadScene(sceneIndex - 1);

            else
                Application.Quit();
        }
    }
}
