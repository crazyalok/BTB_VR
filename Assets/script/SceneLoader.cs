using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene() {
        SceneManager.LoadScene(1);
    }

}

