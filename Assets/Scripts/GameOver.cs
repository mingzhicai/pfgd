using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject whitedonut;
    public GameObject blackdonut;
    public GameObject blackscoretext;
    public GameObject whitescoretext;
    private GameObject[] whitebricks;
    private GameObject[] blackbricks;
    private int wsl;
    private int bsl;
    private int blackscore;
    private int whitescore;
    public GameObject win;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        win = GameObject.FindGameObjectWithTag("win");
        lose = GameObject.FindGameObjectWithTag("lose");
    }

    // Update is called once per frame
    void Update()
    {
        wsl = WhiteBallBouncer.whitesphereLife;
        bsl = BlackBallBouncer.blacksphereLife;
        whitebricks = GameObject.FindGameObjectsWithTag("whitebrick");
        blackbricks = GameObject.FindGameObjectsWithTag("blackbrick");
        whitescore = 40 - whitebricks.Length;
        blackscore = 40 - blackbricks.Length;
        whitescoretext.GetComponent<TextMesh>().text = "WhiteScore: " + whitescore.ToString();
        blackscoretext.GetComponent<TextMesh>().text = "BlackScore: " + blackscore.ToString();

        if ((whitedonut.GetComponent<BoxCollider>().enabled = false )&& (blackdonut.GetComponent<BoxCollider>().enabled = false))
        {
           
            win.GetComponent<MeshRenderer>().enabled = true;
        }
        if (wsl == 0 && bsl == 0)
        {
            lose.GetComponent<MeshRenderer>().enabled = true;
        }
   
    }
}
