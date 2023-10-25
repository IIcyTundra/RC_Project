using Kitbashery.Gameplay;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float dashForce = 10f;
    public float dashCoolDown = 0.2f;
    public float dashDuration = 0.5f;
    

    private Rigidbody2D rb;
    private bool isDashing;
    private bool canDash;
    private Vector2 m_Movement;
    //private Vector3 lastImagePos;
    

    void Start()
    {
        isDashing = false;
        canDash = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDashing)
        {
            return;
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        m_Movement = new Vector2(moveHorizontal, moveVertical).normalized * moveSpeed;

        rb.velocity = m_Movement;

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        { 
            StartCoroutine(Dash());
        }
    }

   

    IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        rb.velocity = new Vector2(m_Movement.x * dashForce, m_Movement.y * dashForce);
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;
        yield return new WaitForSeconds(dashCoolDown);
        canDash = true;
    }


}

