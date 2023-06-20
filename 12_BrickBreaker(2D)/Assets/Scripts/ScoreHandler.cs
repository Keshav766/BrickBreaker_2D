using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static ScoreHandler instance;

    public int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void IncreaseScore(int num)
    {
        score += num;
    }

}
