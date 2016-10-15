using UnityEngine;
using System.Collections;

public class WheelScript : MonoBehaviour
{
    [SerializeField] private float speed = 50f;

    private WheelJoint2D myWheelJoint2D;

    void Awake()
    {
        myWheelJoint2D = GetComponent<WheelJoint2D>();
    }

    void FixedUpdate()
    {
        JointMotor2D motor = myWheelJoint2D.motor;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            motor.motorSpeed += speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            motor.motorSpeed -= speed;
        }

        myWheelJoint2D.motor = motor;
    }
}