using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int highScore;
    public TextMeshProUGUI scoreText;

    

    private void Start()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
            highScore= 0;
            scoreText.text=highScore.ToString();
        }
        else
        {
            scoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

        /*else
        {
            Load();
        }*/
        /*highScore = PlayerPrefs.GetInt("HighScore", 0);*/
    }

    /*private void Update()
    {
        if (ScoreManager.instance.score > highScore)
        {
            highScore = ScoreManager.instance.score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            scoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }*/

    /*public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }*/

}
