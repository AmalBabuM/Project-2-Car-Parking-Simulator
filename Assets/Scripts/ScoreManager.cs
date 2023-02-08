using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    /*AudioSource audio;*/
   /* AudioClip audioClip;*/
    public int score;
    int point = 1500;
    public static ScoreManager instance;

    private void Start()
    {
      /* audio=GetComponent<AudioSource>(); */
        /*audioClip=audio.clip;*/
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);  
    }
    public void AddScore()
    {
        score+=point;
        textScore.text = score.ToString();
        /*if (score > PlayerPrefs.GetInt("HighScore")) ;
        {
           
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            
        }*/

    }

    /*public void PlayAudio()
    {
        audio.Play();
    }
    public void StopAudio()
    {
        audio.Stop();
    }*/

}
