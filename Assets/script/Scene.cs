using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour {
    public float speed=10;
	void FixedUpdate () {
        transform.Translate(0, 0, 1*speed*Time.deltaTime);
	}
}
