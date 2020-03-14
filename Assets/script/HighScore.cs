using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    private int Highscore;
    public Text highscoreText;
	void Start () {
       highscoreText = GetComponent<Text>();
        Highscore = (int)PlayerPrefs.GetFloat("highscore");
        {
            highscoreText.text = "High Score : " + Highscore;
        }
        print(Highscore);
    }
}
