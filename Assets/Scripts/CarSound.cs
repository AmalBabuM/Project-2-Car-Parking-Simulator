using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSound : MonoBehaviour
{
   /* public float minSpeed;
    public float maxSpeed;

    public float minPitch;
    public float maxPitch;*/
    private float currentSpeed;

    Rigidbody rb;
    AudioSource carAudio;

    private float pitchFromCar;
    // Start is called before the first frame update
    void Start()
    {   
        
        rb = GetComponent<Rigidbody>();
        carAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        EngineSound();
    }

    public void EngineSound()
    {
        currentSpeed = 4 * rb.velocity.magnitude * 3.6f;
        carAudio.pitch = Mathf.Lerp(0.5f,2,currentSpeed * 0.004285f);
       /* pitchFromCar = rb.velocity.magnitude / 50f;
        if (currentSpeed < minSpeed)
        {
            carAudio.pitch = minPitch;
        }
        if (currentSpeed > minSpeed && currentSpeed < maxSpeed)
        {
            carAudio.pitch = minPitch + pitchFromCar;
        }
        if (currentSpeed > maxSpeed)
        {
            carAudio.pitch = maxPitch;
        }*/

    }
    /*int scene;
    private void Update()
    {
        if(Input.GetKeyDown("m"))
        {
            display();
        }
    }
    private void display()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(scene);
    }*/
}
