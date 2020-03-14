using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    private float zero = 0;
    public Text scoretext;
    public void restart()
    {
        PlayerPrefs.SetFloat("hscore", zero);
        SceneManager.LoadScene(1);

	}
}
