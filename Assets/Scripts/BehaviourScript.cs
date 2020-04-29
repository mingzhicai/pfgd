using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    
    void Start()
    {
     
    }

    void OnCollisionEnter(Collision collision)
    {
        sphere.GetComponent<Rigidbody>().useGravity = true;
    }
}
