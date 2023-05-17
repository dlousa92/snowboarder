using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigBod;
    SurfaceEffector2D surfEffector;
    [SerializeField] float torque = 1f;
    [SerializeField] float baseSpeed = 25f;
    [SerializeField] float boostSpeed = 42f;
    bool disableControls = false;
    Score score;

    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody2D>();
        surfEffector = FindObjectOfType<SurfaceEffector2D>();
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (disableControls) {
            return;
        }

        RotatePlayer();
        BoostPlayer();
    }

    public void DisableControls()
    {
        disableControls = true;
    }

    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfEffector.speed = boostSpeed;

        }
        else
        {
            surfEffector.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigBod.AddTorque(torque);
            score.IncreaseTotalScore();
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigBod.AddTorque(-torque);
            score.IncreaseTotalScore();
        }
    }
}
