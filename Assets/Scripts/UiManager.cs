using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.GetCurrentScore();
    }
}
