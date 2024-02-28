using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIScript : MonoBehaviour
{
    private SingletonData score;
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    
    void Awake()
    {
        score = SingletonData.Instance;
        highscoreText.text = score.HighScore.ToString();
    }
    void Update()
    {
        scoreText.text = score.CurrentScore.ToString();
    }
}
