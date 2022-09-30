using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreCount.Scorevalue += 1;
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 3));
    }
}