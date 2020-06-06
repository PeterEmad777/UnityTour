using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityScript.Steps;

public class Movement : MonoBehaviour
{

    // Use this for initialization

    public float maxSpeed = 100;
    public float moveSpeed = 0.01F;
    private Animator animator;
    public AudioSource audio;

    private Vector3 moveDirection;
    public bool run;

    Vector2 input;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null) return;
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        moveDirection = (transform.forward * y * moveSpeed) + (transform.right * x * moveSpeed);
        move(x, y);

    }
    private void move(float x, float y)
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetFloat("VelX", x);
            animator.SetFloat("VelY", y * 2);
            transform.position += moveDirection * Time.deltaTime;
            if (run == false)
            {
                run = true;
                audio.Play();
            }
        }

        else
        {
            animator.SetFloat("VelX", x);
            animator.SetFloat("VelY", y);
            transform.position += moveDirection * Time.deltaTime;
            if (run == false)
            {
                run = true;
                audio.Play();
            }
        }
        if (!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
        {
            if (run == true)
            {
                run = false;
                audio.Stop();
            }
        }
    }
}

