using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;

    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        button.transform.Translate(0,-Time.deltaTime,0);
    }
}
