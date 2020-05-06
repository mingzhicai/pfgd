using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public GameObject blackscoretext;
    public GameObject whitescoretext;
    private GameObject[] whitebricks;
    private GameObject[] blackbricks;
    private int blackscore;
    private int whitescore;
    public GameObject win;
    public GameObject restart;
    public TextMesh whitetext = GameObject.Find("WhiteScore").GetComponent<TextMesh>();
    public TextMesh blacktext = GameObject.Find("BlackScore").GetComponent<TextMesh>();

    public MeshRenderer b = GameObject.Find("BlackCore").GetComponent<MeshRenderer>();
    public MeshRenderer w = GameObject.Find("WhiteCore").GetComponent<MeshRenderer>();

    // Start is called before the first frame update
    void Start()
    {
        whitetext.text = "WhiteScore: ";
        blacktext.text = "BlackScore: " + blackscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        whitebricks = GameObject.FindGameObjectsWithTag("whitebrick");
        blackbricks = GameObject.FindGameObjectsWithTag("blackbrick");
        whitescore = 64 - whitebricks.Length;
        blackscore = 64 - blackbricks.Length;
        whitetext.text = "White◼︎: " + whitescore.ToString(); 
        blacktext.text = "Black◼︎: " + blackscore.ToString();
       


        if (b.enabled == true && w.enabled == true)
        {
            win.GetComponent<MeshRenderer>().enabled = true;
            restart.GetComponent<MeshRenderer>().enabled = true;
            restart.GetComponent<BoxCollider>().enabled = true;
        }

    }
}
