using UnityEngine;
using System.Collections;

public class Gyro : MonoBehaviour { 
   private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        Vector3 previousEulerAngles = transform.eulerAngles;
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        Vector3 targetEulerAngles = previousEulerAngles + gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        targetEulerAngles.x = 0.0f; 
        targetEulerAngles.y = 0.0f;
        if ((targetEulerAngles.z<=30) || (targetEulerAngles.z>=325 ))
        {
            transform.eulerAngles = targetEulerAngles;
        }
        else
        {
            StopGyro();  
        }
    }
    public void StopGyro()
    {
        Input.gyro.enabled = false;
        SendMessage("StopControl");
    }

}