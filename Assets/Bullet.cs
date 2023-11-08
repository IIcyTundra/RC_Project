using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Kitbashery.Gameplay;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{


    [Header("Projectile:")]
    public Rigidbody2D rigid;

    [Space]
    [Tooltip("Should force be applied to the hit rigidbody?")]
    public bool applyForceOnImpact = true;
    [Tooltip("Force applied to the rigidbody of hit colliders.")]
    public float impactForce = 1f;
    [Tooltip("Initial velocity of the rigidbody.")]
    public float velocity = 500f;

    [Space]
    [Tooltip("Should the projectile be disabled on impact? (useful for pooling).")]
    public bool disableOnImpact = true;
    [Tooltip("Should the GameObject be deactivated after lifeTime has elapsed.")]
    public bool useLifeTime = true;
    [Tooltip("How long this projectile will live before being deactivated (in seconds).")]
    public float lifeTime = 10f;
    [Min(0)]
    private float life = 0f;




    private void Awake()
    {

        if (rigid == null)
        {
            rigid = gameObject.GetComponent<Rigidbody2D>();
        }
    }


    private void OnEnable()
    {
        rigid.velocity = Vector2.zero;
        rigid.AddForce(transform.forward * velocity, ForceMode2D.Impulse);
    }

    private void OnDisable()
    {
        transform.position = Vector2.zero;
        transform.rotation = Quaternion.identity;
        life = 0;
    }

    private void Update()
    {
        if (useLifeTime == true)
        {
            life += Time.deltaTime;
            if (life >= lifeTime)
            {
                gameObject.SetActive(false);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }


}