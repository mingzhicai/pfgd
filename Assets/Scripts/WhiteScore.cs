using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteScore : MonoBehaviour
{
    public GameObject whitescore;
    private GameObject[] whitebricks;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        whitebricks = GameObject.FindGameObjectsWithTag("whitebrick");
 
      
    }
}
