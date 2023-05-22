using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Image timerImage;
    Score score;
    FinishLine finishLine;
    float fillFraction;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        finishLine = FindObjectOfType<FinishLine>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
        UpdateTimer();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.GetCurrentScore();
    }

    void UpdateTimer()
    {
        fillFraction = score.GetFillFractionValue();
        timerImage.fillAmount = fillFraction;
    }
}
