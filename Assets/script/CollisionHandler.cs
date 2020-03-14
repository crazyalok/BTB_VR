using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {
    private int count=0;
    void Start ()
    {
        print("Entered");
    }
    void OnTriggerEnter(Collider other)
    {
        print("triggered");
        
        SendMessage("StopGyro");
        count++;
        PlayerPrefs.SetInt("eero", count);
        SceneManager.LoadScene(4);
        
        
    }
}
