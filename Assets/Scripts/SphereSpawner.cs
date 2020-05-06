using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject whitespherePrefab;
    public GameObject blackspherePrefab;
    private GameObject[] whitespheres;
    private GameObject[] blackspheres;  
    private int wsl;
    private int bsl;
    private int white_num =4;
    private int black_num =4;
    void Start()
    {

        
    }


    // Update is called once per frame
    void Update()
    {
        wsl = WhiteBallBouncer.whitesphereLife;
        bsl = BlackBallBouncer.blacksphereLife;
        whitespheres = GameObject.FindGameObjectsWithTag("whitesphere");
        blackspheres = GameObject.FindGameObjectsWithTag("blacksphere");
        if (white_num >= 1)
        {
            if (whitespheres.Length <= 1)
            {
                Instantiate(whitespherePrefab, new Vector3(0, 1, 0), Quaternion.identity);
                white_num--;
            }
        }
        if (black_num >= 1)
        {
            if (blackspheres.Length <= 1)
            {
                Instantiate(blackspherePrefab, new Vector3(0, 1, 0), Quaternion.identity);
                black_num--;
            }
        }
    }
}
