using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float resetLevelTimer = 1f;
    [SerializeField] int levelIndex = 0;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] ParticleSystem finishEffect2;
    [SerializeField] ParticleSystem finishEffect3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finishEffect.Play();
            finishEffect2.Play();
            finishEffect3.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ResetLevel", resetLevelTimer);
        }
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
