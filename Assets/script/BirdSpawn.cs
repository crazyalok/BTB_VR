using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawn : MonoBehaviour {
    private float spawnz = 50f,spawnz1 = 100f;
    public GameObject[] prefab;
    public GameObject[] prefabs;
    private float Length = 323f;
    private int amount = 2;
    public float px,py;
    private List<GameObject> activeTiles ;
    private Transform playertransform;
	void Start () {
        activeTiles = new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	void Update () {
		if(playertransform.position.z > (spawnz - amount * Length))
        {
            spawn(0);
        }
	}
    void spawn(int prefabindex)
    {
        GameObject go,go1;
       px = Random.Range(985.57f, 988.87f);
        py = Random.Range(993.37f, 996.67f);
       go = Instantiate(prefab[prefabindex],new Vector3(px, 468.05f, 1 * spawnz), Quaternion.Euler(0, 180, 0)) as GameObject;
        go1 = Instantiate(prefabs[prefabindex], new Vector3(py, 468.05f, 2 * spawnz1), Quaternion.Euler(0, 180, 0)) as GameObject;
      go.transform.SetParent(transform);
        go1.transform.SetParent(transform);
        spawnz += Length;
        spawnz1 += Length;
    }
}
