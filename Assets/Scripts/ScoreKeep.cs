using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
    public static int highScore;
    public static int currScore;
    void Start()
    {
        highScore = 0;
        currScore = 0;
    }
}
