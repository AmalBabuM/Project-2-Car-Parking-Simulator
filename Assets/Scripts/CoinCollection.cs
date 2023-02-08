using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public SceneScore SS;
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coin")
        {
            Debug.Log("Hi");
            SS.AddScore();
            /*ScoreManager.instance.AddScore();*/

            Destroy(other.gameObject);
        }
    }
}
