using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parking : MonoBehaviour
{
    public Material parkLight;

    private void Start()
    {
        parkLight.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("BackWheel"))
        {
            parkLight.color = Color.green;
            Invoke("LoadScene", 1f);
        }
       /*else
        {
            parkLight.color = Color.red;
        }*/
    }
    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    /* private void OnCollisionEnter(Collision collision)
     {
         parkLight.color = Color.green;
     }*/
}
