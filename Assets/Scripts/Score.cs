using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int currentScore;
    [SerializeField] float scoreDivider = 10;
    DustTrail dustTrail;

    private void Start() 
    {
        dustTrail = FindObjectOfType<DustTrail>();
    }

    public int GetCurrentScore()
    {
        return Mathf.RoundToInt(currentScore / scoreDivider);
    }

    public void IncreaseTotalScore()
    {
        if (dustTrail.GetIsTouchingSurface())
        {
            return;
        }
        
        currentScore++;
    }

    public int GetFinalScore(float timerRemainder)
    {
        return Mathf.RoundToInt(currentScore + timerRemainder);
    }
}
