using Kitbashery.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dashSpeed = 10f;
    public float dashDuration = 0.2f;
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

        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing)
        {
            isDashing = true;
            //ObjectPools.Instance.GetPooledObject(0);
            //lastImagePos = transform.position;
            StartCoroutine(Dash());
        }
    }

    IEnumerator Dash()
    {
        float startTime = Time.time;

        Vector2 dashDirection = rb.velocity.normalized;

        if (dashDirection == Vector2.zero)
        {
            dashDirection = transform.up;
        }

        

        while (Time.time < startTime + dashDuration)
        {
            rb.velocity = dashDirection * dashSpeed;

            //if (Mathf.Abs(Vector3.Distance(transform.position, lastImagePos)) > distanceBewteenImages)
            //{
            //    ObjectPools.Instance.GetPooledObject("AfterImage");
            //    lastImagePos = transform.position;
            //}
            yield return null;
        }

        

        isDashing = false;
    }
}

