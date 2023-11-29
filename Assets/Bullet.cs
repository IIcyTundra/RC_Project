using Kitbashery.Gameplay;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletMechanics : MonoBehaviour
{
    [Header("Projectile:")]
    public Rigidbody2D rigid;
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

    [Header("Explosive Settings:")]
    public bool isExplosive = false;
    [Tooltip("Explosion radius if the bullet is explosive.")]
    public float explosionRadius = 5f;


    private void Awake()
    {
        if (rigid == null)
        {
            rigid = gameObject.GetComponent<Rigidbody2D>();
        }
    }

    private void OnEnable()
    {
        rigid.velocity = Vector3.zero;
        rigid.AddForce(transform.right * velocity, ForceMode2D.Impulse);
    }

    private void OnDisable()
    {
        transform.position = Vector3.zero;
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
        if (isExplosive)
        {
            Explode();
        }

        gameObject.SetActive(false);
    }

    private void Explode()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        foreach (Collider2D hitCollider in colliders)
        {
            if(hitCollider.gameObject?.GetComponent<EnemyAi>())
            {
                //hitCollider.gameObject?.GetComponent<EnemyAi>().
            }
        }
    }

}