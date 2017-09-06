using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTower : MonoBehaviour
{


    public Mesh firstMesh;
    public Mesh midMesh;
    public Mesh finalMesh;

    public GameObject Hammer;

    public Vector3 hammerLocation;
    public float hammerRotation = 60f;

    public float waitTime = 5.0f;
    public float hammerWaitTime = 8.0f;



    public bool startDelay;

    // Use this for initialization
    void Start()
    {

        GetComponent<MeshFilter>().sharedMesh = firstMesh;

        startDelay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<MeshFilter>().sharedMesh = midMesh;
            startDelay = true;
            Hammer.SetActive(true);

        }

        if (startDelay == true)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0.0f)
            {
                GetComponent<MeshFilter>().sharedMesh = finalMesh;

            }



            hammerWaitTime -= Time.deltaTime;
            if (hammerWaitTime <= 0.0f)
            {
                Hammer.SetActive(false);
                startDelay = false;
            }
        }

    }

}
