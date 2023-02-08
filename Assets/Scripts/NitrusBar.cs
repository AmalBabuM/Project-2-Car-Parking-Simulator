using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NitrusBar : MonoBehaviour
{
    public ParticleSystem[] flame;
    public float nitrusValue=5f;
    public bool nitrusFlag;
    bool boosting;
    public Slider nitroSlider;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ActivateNirtus();
        NitroUI();
    }
    public void ActivateNirtus()
    {
        boosting = Input.GetKey(KeyCode.LeftShift);
        if (!boosting && nitrusValue<5f)
        {
            nitrusValue += Time.deltaTime / 2;
        }
        else
        {
            nitrusValue-= (nitrusValue<=0)?0:Time.deltaTime;
        }
        if(boosting && nitrusValue>0)
        {
            StartNitro();
        }
        else
        {
            StopNitro();
        }
    }
    public void NitroUI()
    {
        /*Debug.Log(nitrusValue);*/
        nitroSlider.value = nitrusValue / 20;
    }
    public void StartNitro()
    {
        rb.AddForce(transform.forward * 10000);
        if (nitrusFlag) return;
        foreach(var item in flame)
        {
            item.Play();
        }
        
        nitrusFlag= true;
    }
    public void StopNitro()
    {
        foreach (var item in flame)
        {
            item.Stop();
        }
        nitrusFlag= false;
    }
}
