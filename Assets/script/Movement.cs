using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private bool controls = true;
    public float moveSpeed = 10;
void FixedUpdate()
    {
        if(controls)
        {
            check();
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
    public void check()
    {
        transform.Translate(0, 0, 1 * moveSpeed * Time.deltaTime );
    }
    public void StopControl()
    {
        controls = false;
    }
}
