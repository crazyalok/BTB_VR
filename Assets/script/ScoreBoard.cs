using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
    private float score = 0.0f;
    public Text scoreText;
    private bool isrunning = true;
	void Start () {
        
	}
	void Update () {
        if (isrunning)
        {
            score += Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            
        }
    }
    public void OnDeath()
    {
        isrunning = false;
        PlayerPrefs.SetFloat("highscore", score);
    }
}
