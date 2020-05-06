using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDonut : MonoBehaviour
{
    public GameObject whitedonut;

    void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "whitesphere")
        {
            foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = true;
            whitedonut.GetComponent<BoxCollider>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
