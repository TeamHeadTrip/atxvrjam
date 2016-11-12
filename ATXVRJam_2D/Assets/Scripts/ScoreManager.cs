using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager: MonoBehaviour
{
    public static int score;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();

        // Reset score to 0
        score = 0;
    }

    void Update()
    {
        //Show the score value
        text.text = "Score: " + score;
    }
}