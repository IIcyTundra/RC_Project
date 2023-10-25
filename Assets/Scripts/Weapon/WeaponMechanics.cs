using Kitbashery.Gameplay;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponMechanics : MonoBehaviour
{
    [SerializeField] private WeaponData m_WeaponData;
    [SerializeField] private Transform[] WeaponMuzzles;
    

    private float timeBetweenShots;
    private float nextShotTime;
    private float timeSinceLastShot;
    private bool triggerReleasedSinceLastShot;
    private int shotsRemainingInBurst;
    private int projectilesRemainingInMag;

    

    bool isReloading;

    AudioSource source;

    private void Start()
    {
        WeaponManager.ShootInputDown += OnTriggerHeld;
        WeaponManager.ShootInputUp += OnTriggerReleased;


        nextShotTime = Time.time;
        shotsRemainingInBurst = m_WeaponData.burstCount;
        projectilesRemainingInMag = m_WeaponData.ProjectilesPerMag;
        source = GetComponent<AudioSource>();
        timeBetweenShots = 1.0f / m_WeaponData.RateOfFire;
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
    }

    private bool CanShoot() =>  timeSinceLastShot > 1f / (m_WeaponData.RateOfFire / 60f);

    private void Shoot()
    {
        if (CanShoot())
        {
            // Firemodes
            if (m_WeaponData.fireMode == FireMode.Burst)
            {
                if (shotsRemainingInBurst == 0)
                {
                    return;
                }
                shotsRemainingInBurst--;
            }
            else if (m_WeaponData.fireMode == FireMode.Single)
            {
                if (!triggerReleasedSinceLastShot) return;
            }


            nextShotTime = Time.time + timeBetweenShots;
            // Spawn projectiles
            SpawnBullet();


            //source.PlayOneShot(m_WeaponData.ShootAudio[Random.Range(0, m_WeaponData.ShootAudio.Length)], 1);
        }
    }

    private void SpawnBullet()
    {
        GameObject bullet = ObjectPools.Instance.GetPooledObject(0);
        for (int i = 0; i < WeaponMuzzles.Length; i++)
        {
            bullet.transform.SetPositionAndRotation(WeaponMuzzles[i].position, WeaponMuzzles[i].rotation);
            bullet.SetActive(true);

            if (bullet.GetComponent<Bullet>())
            {
                bullet.GetComponent<Bullet>().rigid.AddForce(WeaponMuzzles[i].right * m_WeaponData.ProjectileSpeed, ForceMode2D.Impulse);
            }
        }

    }

    private void OnTriggerHeld()
    {
        Shoot();
        triggerReleasedSinceLastShot = false;
    }
    private void OnTriggerReleased()
    {
        triggerReleasedSinceLastShot = true;
        shotsRemainingInBurst = m_WeaponData.burstCount;
    }

}
