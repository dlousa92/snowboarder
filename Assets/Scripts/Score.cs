using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int currentScore;
    [SerializeField] float scoreMultiplyer = 10;

    public int GetCurrentScore()
    {
        return Mathf.RoundToInt(currentScore / scoreMultiplyer);
    }

    public void IncreaseTotalScore()
    {
        currentScore++;
    }

    public int GetFinalScore(float timerRemainder)
    {
        return Mathf.RoundToInt(currentScore + timerRemainder);
    }
}
