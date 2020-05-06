using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackDonut : MonoBehaviour
{
    public GameObject blackdonut;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "blacksphere")
        {
            foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = true;
            blackdonut.GetComponent<BoxCollider>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
