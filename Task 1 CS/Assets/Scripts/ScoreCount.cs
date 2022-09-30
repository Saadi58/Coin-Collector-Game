using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCount : MonoBehaviour
{
    public static int Scorevalue;
    public TextMeshProUGUI Score;

    void Update()
    {
        Score.text = "Score: " + Scorevalue.ToString();
    }
}