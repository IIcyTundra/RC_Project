using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    //Gun Settings
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefabs;

    //States of Enemy
    public GameObject player;
    public int health;
    public float speed;
    public float followRadius;
    public float attackRadius;

    public float distance = 0;
    void Start()
    {
        
    }
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        if(distance < followRadius)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

            if(distance < attackRadius)
            {
               
            }
        }
    }
    
}
