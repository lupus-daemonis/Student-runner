using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private float highScore;

    private void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Gameover") == null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
        else
        {
            CheckScore();
        }
    }

    public void CheckScore()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
    }
}
