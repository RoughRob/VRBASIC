using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public int enemyCount;
    public float rate = 1.0f;
    public float velocityX, velocityY, velocityZ;

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
            Instantiate(enemy, gameObject.transform.localPosition, gameObject.transform.localRotation);
            enemy.GetComponent<Rigidbody>().velocity = new Vector3 (velocityX, velocityY, velocityZ);
            yield return new WaitForSeconds(rate);
        }
    }
}
