using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteOrbit : MonoBehaviour
{
    public GameObject target;
    public float speed;

    void Start()
    {
       
    }


    void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(target.transform.position,Vector3.right,speed*Time.deltaTime);
    }

}
