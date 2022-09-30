//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{
    //To Create a refferance with Rigidody componnent
    public Rigidbody RB;

    //To Declare a variable for Spped on the ball
    public float BallSpeed = 500f;

    //To Declare a variable for Movement on the ball
    public float MovementSpeed = 500f;

    void FixedUpdate()
    {
        //To Add Speed on the Ball

        RB.AddForce(0, 0, BallSpeed * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            RB.AddForce(MovementSpeed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange );
        }

        if (Input.GetKey("a"))
        {
            RB.AddForce(-MovementSpeed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        if (RB.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Gameover();
        }
    }
}
