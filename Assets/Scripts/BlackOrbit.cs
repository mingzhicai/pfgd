using UnityEngine;
using System.Collections;

public class BlackOrbit : MonoBehaviour
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
        transform.RotateAround(target.transform.position, Vector3.forward, speed * Time.deltaTime);
    }

}
