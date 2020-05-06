using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLife : MonoBehaviour
{
    private int wsl;
    private int bsl;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       wsl = WhiteBallBouncer.whitesphereLife;
       bsl = BlackBallBouncer.blacksphereLife;
        if (wsl < 4)
        {
            Destroy(GameObject.Find("White4"));
        }
        if (wsl < 3)
        {
            Destroy(GameObject.Find("White3"));
        }
        if (wsl < 2)
        {
            Destroy(GameObject.Find("White2"));
        }
        if (wsl < 1)
        {
            Destroy(GameObject.Find("White1"));
        }
        if (bsl < 4)
        {
            Destroy(GameObject.Find("Black4"));
        }
        if (bsl < 3)
        {
            Destroy(GameObject.Find("Black3"));
        }
        if (bsl < 2)
        {
            Destroy(GameObject.Find("Black2"));
        }
        if (bsl < 1)
        {
            Destroy(GameObject.Find("Black1"));
        }
    }
}
