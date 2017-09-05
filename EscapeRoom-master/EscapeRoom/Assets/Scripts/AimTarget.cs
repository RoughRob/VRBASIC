using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTarget : MonoBehaviour {

    public Rigidbody bullet;
    public Transform fireFrom;

    //public bool bulletDrop;

    public int bulletSpeed;

    private GameObject activeTarget;

    public List<Transform> targets = new List<Transform>();

    int i = 0;
    // Use this for initialization
    void Start()
    {

        //activeTarget = GameObject.Find("Target");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody Bullet;
            Bullet = Instantiate(bullet, fireFrom.position, fireFrom.rotation) as Rigidbody;
            Bullet.AddForce(fireFrom.forward * bulletSpeed);
        }
    }

    public void ActiveTarget()
    {
        //activeTarget = targets[0];
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("target entered");
        targets.Add(other.transform);

        i++;
        Debug.Log("target added to targets");


    }

    private void OnTriggerExit(Collider other)
    {

        targets.Remove(other.transform);
        //if (targets.Count > 0)

        Debug.Log("target exited");


        i--;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("target is inside");
        transform.LookAt(targets[0]);
    }
}
