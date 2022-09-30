using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oncollision : MonoBehaviour
{
    public BallMovement Movement;

    public int WiningScore = 60;
   


    private void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "EndPoint")
        {
            if(ScoreCount.Scorevalue >= WiningScore)
            {

                Debug.Log("win");
                Movement.enabled = false;
                FindObjectOfType<GameManager>().Gamewin(); 
            }
            else 
            {
                Debug.Log("over");
                Movement.enabled = false;
                FindObjectOfType<GameManager>().Gameover();
            }
            
        }
    }
}