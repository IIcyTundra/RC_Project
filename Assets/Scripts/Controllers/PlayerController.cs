using Kitbashery.Gameplay;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float dashDuration;
    public float dashDistance;
    private float dashTime;
    public float distanceBewteenImages;

    private bool isDashing = false;
    private Rigidbody2D rb;
    //private Vector3 lastImagePos;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized * moveSpeed;

        rb.velocity = movement;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        { 
            Dash(movement);
        }
    }

    void Dash(Vector2 movement)
    {
        if (Time.time >= dashTime)
        {
            dashTime = Time.time + dashDuration;

            rb.velocity = movement.normalized * dashDistance;
        }
    }


}

