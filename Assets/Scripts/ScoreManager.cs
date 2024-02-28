using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public SingletonData score;
    
    private void Start()
    {
      ResetScore();
    }
    void Awake()
    {
        score = SingletonData.Instance;
    }

    public void AddScore(float addition)
    {
        score.AddScore(addition);
    }

    public void ResetScore()
    {
      score.ResetScore();
    }
}
