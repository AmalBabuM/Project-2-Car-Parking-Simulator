using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    public GameObject brakeLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BrakeLight();
    }
    private void BrakeLight()
    {
        if(Input.GetKey(KeyCode.Space)) {
            
            brakeLight.SetActive(true);
        }
        else
        {
            brakeLight.SetActive(false);
        }
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coin")
        {
            Debug.Log("Hi");
        }
    }*/
    
}
