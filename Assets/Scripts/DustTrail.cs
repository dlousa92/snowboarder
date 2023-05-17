using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour 

{
    [SerializeField] ParticleSystem snowEffect;
    [SerializeField] AudioClip snowboardSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           snowEffect.Play();
           GetComponent<AudioSource>().Play();
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        snowEffect.Stop();
        GetComponent<AudioSource>().Stop();
    }
}
