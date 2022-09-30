//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform BallPosition;

    // To control the position of camera
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = BallPosition.position + Offset;
    }
}
