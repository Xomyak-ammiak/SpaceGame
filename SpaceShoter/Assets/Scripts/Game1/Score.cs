using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text maxScoreText;

    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        PlayerPrefs.SetInt("Score", score);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(PlayerPrefs.GetInt("ToLose") == 0)
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
            PlayerPrefs.SetInt("Score", score);
        } else
        {
            maxScoreText.text = "Max Score:\n" + PlayerPrefs.GetInt("MaxScore").ToString();
        }
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", score);
        }
    }
}
