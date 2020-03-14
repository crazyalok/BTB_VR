using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    private bool running;
    public Transform player;
    public Text scoreText;
    public  float score=0;
    public float nex, c;
    void Start ()
    {
        print("running");
        running = true;
        print(running);
        nex = score;
    }
      void Update ()
    {
        running = true;
        if (running)
        {
            score = (player.position.z + 905.8999f) / 100;
            scoreText.text = score.ToString("0");
            print(score);
            if (PlayerPrefs.GetInt("eero") > 0)
            {
                run();
            }
        }
    }
    public void run()
    {
        nex = score;
        PlayerPrefs.SetFloat("mscore", nex);
        if (nex > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", nex);
        }
        running = false;
    }
   }
