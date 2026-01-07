using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static Text scoretext;
    public static int scorenum = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + scorenum;
    }

    // Method to reset the score to 0
    public static void ResetScore()
    {
        scorenum = 0;
    }
}
