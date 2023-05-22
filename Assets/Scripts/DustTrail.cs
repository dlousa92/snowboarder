using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour 

{
    [SerializeField] ParticleSystem snowEffect;
    [SerializeField] AudioClip snowboardSFX;
    bool isTouchingSurface;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           snowEffect.Play();
           GetComponent<AudioSource>().Play();
           SetIsTouchingSurface(true);
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        snowEffect.Stop();
        GetComponent<AudioSource>().Stop();
        SetIsTouchingSurface(false);
    }

    public void SetIsTouchingSurface(bool touchingSurface)
    {
        isTouchingSurface = touchingSurface;
    }

    public bool GetIsTouchingSurface()
    {
        return isTouchingSurface;
    }
}
