﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "sphere")
        {
            Destroy(targetObj.gameObject);
        }
    }



}
