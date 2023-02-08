using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum Axel
{
    Front,
    Rear
}
[Serializable]
public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}
public class WheelScript : MonoBehaviour
{
    public float maxSpeed=100f;
    [SerializeField]
    private float maxAcceleration = 20.0f;
    [SerializeField]
    private float turnSensitivity = 1.0f;
    [SerializeField]
    private float maxSteerAngle = 45.0f;
    [SerializeField]
    private Vector3 centerOfMass;
    [SerializeField]
    private List<Wheel> wheels;
   
    private float inputX, inputY;
    private Rigidbody rb;
    public float speed = 20f;
    public float currentVelocity = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*rb.centerOfMass = centerOfMass;*/
    }

    void Update()
    {
        AnimateWheels();
        GetInputs();
    }
    private void LateUpdate()
    {
        Move();
        /*Drive();*/
        Turn();
    }
    private void GetInputs()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        
    }

    /*private void Drive()
    {
        bool go = Input.GetKey("w");
        *//*currentVelocity = rb.velocity.sqrMagnitude;*/
    /*Debug.Log("Horizontal speed is : "+ inputX);
    Debug.Log("Vertical speed is : " + inputY);*//*
    foreach (var wheel in wheels)
    {
        currentVelocity = wheel.collider.motorTorque;
        if(go && currentVelocity<maxSpeed )
        {
            wheel.collider.motorTorque += Time.deltaTime * speed;  
        }
        else if(!go && currentVelocity>0 ) 
        {
            wheel.collider.motorTorque -= Time.deltaTime * speed;            
        }

    }
    Debug.Log(currentVelocity);
}*/

    private void Move()
    {
        float currentSpeed = rb.velocity.sqrMagnitude;
        Debug.Log(currentSpeed);
        Debug.Log(maxSpeed);
        if (currentSpeed > maxSpeed)
        {

            return;
        }
        foreach (var wheel in wheels)
        {
            if (wheel.axel == Axel.Rear)
            {
                wheel.collider.motorTorque = inputY * maxAcceleration * speed * Time.deltaTime;
            }


        }
    }

    private void Turn()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel==Axel.Front)
            {
                var _steerAngle= inputX * turnSensitivity * maxSteerAngle;
                wheel.collider.steerAngle= Mathf.Lerp(wheel.collider.steerAngle,_steerAngle,0.5f);
            }
        }
    }
    private void AnimateWheels()
    {
        foreach(var wheel in wheels)
        {
            Quaternion _rot;
            Vector3 _pos;
            wheel.collider.GetWorldPose(out _pos, out _rot);
            wheel.model.transform.position= _pos;
            wheel.model.transform.rotation= _rot;
        }
    }
}
