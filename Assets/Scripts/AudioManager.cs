using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource audio;

    public static AudioManager instance;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
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

    public void PlayStop()
    {
        if (audio.isPlaying)
        {
            audio.Pause();
        }
        else
        {
            audio.Play();
        }
    }
}
