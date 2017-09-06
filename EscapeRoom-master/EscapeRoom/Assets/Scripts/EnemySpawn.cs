using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public int enemyCount;
    public float rate = 1.0f, xStart, xEnd, yStart, yEnd, zStart, zEnd;
    public float enemyXRotation, enemyYRotation, enemyZRotation, enemyWRotation;

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
            float x = Random.Range(xStart, xEnd);
            float y = Random.Range(yStart, yEnd);
            float z = Random.Range(zStart, zEnd);
            Quaternion rotationOfEnemy = new Quaternion(enemyXRotation, enemyYRotation, enemyZRotation, enemyWRotation);
            Instantiate(enemy, new Vector3(x, y, z), rotationOfEnemy);
            yield return new WaitForSeconds(rate);
        }
    }
}
