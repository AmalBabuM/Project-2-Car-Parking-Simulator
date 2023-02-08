using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public TextMeshProUGUI timeText;
    
    void Update()
    {
        if(timeValue>0.0f)
        {
            timeValue-= Time.deltaTime;
        }
        else if(timeValue<=0.0f)
        {
            
            timeValue = 0.0f;
            

        }
        DisplayTime(timeValue);
    }
    void DisplayTime(float TimeToDisplay)
    {
        if(TimeToDisplay<0)
        {
            
            TimeToDisplay = 0;
            SceneManager.LoadScene(6);
            Debug.Log("HI");
            return;
        }
        float minute=Mathf.Floor(TimeToDisplay/60);
        float second=Mathf.Floor(TimeToDisplay%60);
        timeText.text = string.Format("{0:00}:{1:00}",minute,second);
    }
}
