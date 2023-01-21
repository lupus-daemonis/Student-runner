using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textHighScore;

    private void Awake()
    {
        textHighScore.text = "High Score: " + ((int)PlayerPrefs.GetFloat("HighScore", 0)).ToString();
    }
    public void Play(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
