using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    private int score;
    public Text yourscore;
    void Start()
    {
        yourscore = GetComponent<Text>();
        score = (int)PlayerPrefs.GetFloat("mscore");
        {
            yourscore.text = "Your Score : " + score;
        }
    }
}
