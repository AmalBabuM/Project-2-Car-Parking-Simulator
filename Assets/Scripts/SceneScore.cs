using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneScore : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    /*AudioSource audio;*/
    /* AudioClip audioClip;*/
    public static int score;

    /*int point = 1500;*/

    int highScore;
    private void Start()
    {   Debug.Log("HighScore is : "+ PlayerPrefs.GetInt("HighScore"));
        highScore = PlayerPrefs.GetInt("HighScore");
        textScore.text = score.ToString();
        /* audio=GetComponent<AudioSource>(); */
        /*audioClip=audio.clip;*/
    }
    public void ResetNum()
    {
        /*Debug.Log("byee");*/
        SceneScore.score= 0;
        textScore.text = score.ToString();
    }

    
    public void AddScore()
    {
        
        score += 1500;
        textScore.text = score.ToString();
        if (score > highScore)
        {

            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            Debug.Log("Updated value : " + PlayerPrefs.GetInt("HighScore"));

        }


    }
}
