using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public int enemyCount;
    public float rate = 1.0f;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Spawn());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Spawn()
    {
        while(true)
        { 
            Instantiate(enemy, new Vector3((float)-5.72, (float)-0.13, Random.Range(-2.0f, 3.0f)), Quaternion.identity);
            yield return new WaitForSeconds(rate);
        }
    }
}
