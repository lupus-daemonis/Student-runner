using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    public Text scoreText;
    public Text resultText;
    private float highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Collector")
        {
            ShowPanel();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Nerd")
        {
            Health.health -= 1;
            other.gameObject.SetActive(false);
            if (Health.health < 0)
            {
                ShowPanel();
            }
        }       
    }

    public void ShowPanel()
    {
        GameOverPanel.SetActive(true);
        if (float.Parse(scoreText.text) > highScore)
        {
            resultText.text = "New high score!";
            resultText.GetComponent<Text>().color = new Color(0, 255, 0);
        }
        else
        {
            resultText.text = "High score: " + ((int)highScore).ToString();
            resultText.GetComponent<Text>().color = new Color(50, 50, 50);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
