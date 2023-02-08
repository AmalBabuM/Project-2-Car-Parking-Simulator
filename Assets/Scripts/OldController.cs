using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldController : MonoBehaviour
{

    /*internal enum gearBox
    {
        automatic,
        manual
    }
    [SerializeField] private gearBox gearchange;*/


    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;


    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    


    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    public float currentAcceleration=0f;
    public float currentBreakForce=0f;
    public float currentTurnAngle=0f;

    public Rigidbody rb;
    public float kph;

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveVehicle();
    }

    private void MoveVehicle()
    {
        currentAcceleration = acceleration * Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;
       /* Debug.Log(currentAcceleration);*/

        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;

        /*frontRight.brakeTorque= currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;*/
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(backRight, backRightTransform);
        UpdateWheel(backLeft, backLeftTransform);

        kph = 4*rb.velocity.magnitude * 3.6f;
    }

    private void UpdateWheel(WheelCollider col, Transform tran)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation); // This takes the world position and rotation value of the wheel from the world space and outputs the value

        tran.position = position; //sets the wheel position and rate which we took from above
        tran.rotation = rotation;
    }
}
