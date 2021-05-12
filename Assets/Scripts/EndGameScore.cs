using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    public Text highScoreText;
    public Text currScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "Highscore: " + ScoreKeep.highScore;
        currScoreText.text = "Score: " + ScoreKeep.currScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
