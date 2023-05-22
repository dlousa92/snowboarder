using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int currentScore;
    [SerializeField] float scoreDivider = 10f;
    [SerializeField] float timerMultiplier = 100f;
    [SerializeField] float timeToCompleteLevel = 120f;
    DustTrail dustTrail;
    FinishLine finishLine;
    float fillFraction;
    float timerValue;

    void Awake() 
    {
        dustTrail = FindObjectOfType<DustTrail>();
        finishLine = FindObjectOfType<FinishLine>();
        timerValue = timeToCompleteLevel;
    }
    
    void Update()
    {
        if (finishLine.GetPlayerFinished())
        {
            return;
        }

        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        fillFraction = timerValue / timeToCompleteLevel;
    }

    public int GetCurrentScore()
    {
        if (finishLine.GetPlayerFinished()) 
        {
            return Mathf.RoundToInt(currentScore / scoreDivider + (fillFraction * timerMultiplier));
        } else {
            return Mathf.RoundToInt(currentScore / scoreDivider);
        }
        
    }

    public void IncreaseTotalScore()
    {
        if (dustTrail.GetIsTouchingSurface())
        {
            return;
        }

        currentScore++;
    }

    public int GetFinalScore()
    {
        return Mathf.RoundToInt(currentScore + fillFraction);
    }

    public float GetFillFractionValue()
    {
        return fillFraction;
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }
}
