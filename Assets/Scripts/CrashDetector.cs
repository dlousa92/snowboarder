using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float resetLevelTimer = 1f;
    [SerializeField] int levelIndex = 0;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Body"))
        {
            if (!hasCrashed) 
            {
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
            }
            
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("ResetLevel", resetLevelTimer);

            hasCrashed = true;
        }
    }

    private void ResetLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
