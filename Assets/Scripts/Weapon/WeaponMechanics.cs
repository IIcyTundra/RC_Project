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


    float nextShotTime;
    bool triggerReleasedSinceLastShot;
    int shotsRemainingInBurst;
    int projectilesRemainingInMag;


    bool isReloading;

    AudioSource source;

    private void Start()
    {
        nextShotTime = Time.time;
        shotsRemainingInBurst = m_WeaponData.burstCount;
        projectilesRemainingInMag = m_WeaponData.ProjectilesPerMag;
        source = GetComponent<AudioSource>();
        timeBetweenShots = 1.0f / m_WeaponData.RateOfFire;
    }

   

    private void Shoot()
    {
        if (!isReloading && Time.time >= nextShotTime && projectilesRemainingInMag > 0)
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
            SpawnBullet(ShootRaycast());


            // Initiate Recoil
            transform.localPosition -= Vector3.forward * Random.Range(m_WeaponData.kickMinMax.x, m_WeaponData.kickMinMax.y);
            //recoilAngle += Random.Range(m_WeaponData.recoilAngleMinMax.x, m_WeaponData.recoilAngleMinMax.y);
            //recoilAngle = Mathf.Clamp(recoilAngle, 0, 30);




            source.PlayOneShot(m_WeaponData.ShootAudio[Random.Range(0, m_WeaponData.ShootAudio.Length)], 1);
        }
    }

    private Vector3 ShootRaycast()
    {

        Camera mainCamera = GetComponentInParent<Camera>();
        RaycastHit hitInfo;

        if (mainCamera != null)
        {
            Ray ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);

            if (Physics.Raycast(ray, out hitInfo, m_WeaponData.WeaponRange))
            {
                Vector3 hitPoint = hitInfo.point;
                return hitPoint;
            }
            else
            {
                Vector3 endPoint = mainCamera.transform.position + (mainCamera.transform.forward * m_WeaponData.WeaponRange);
                return endPoint;
            }
        }
        else
        {
            Debug.LogWarning("No main camera found!");
        }
        return mainCamera.transform.position + (mainCamera.transform.forward * m_WeaponData.WeaponRange);

    }


    private void SpawnBullet(Vector3 shootPoint)
    {
        GameObject bullet = ObjectPools.Instance.GetPooledObject(0);
        for (int i = 0; i < WeaponMuzzles.Length; i++)
        {
            bullet.transform.SetPositionAndRotation(WeaponMuzzles[i].position, Quaternion.Euler(shootPoint));
            bullet.SetActive(true);

            if (bullet.GetComponent<Projectile>())
            {
                bullet.GetComponent<Projectile>().rigid.AddForce(WeaponMuzzles[i].forward * m_WeaponData.ProjectileSpeed, ForceMode.Impulse);
            }
        }

    }

    public void Reload()
    {
        if (!isReloading && projectilesRemainingInMag != m_WeaponData.ProjectilesPerMag)
        {
            StartCoroutine(AnimateReload());
        }
    }

    IEnumerator AnimateReload()
    {
        isReloading = true;
        yield return new WaitForSeconds(.2f);

        source.PlayOneShot(m_WeaponData.ReloadAudio[Random.Range(0, m_WeaponData.ShootAudio.Length)], 1);

        float reloadSpeed = 1 / m_WeaponData.reloadTime;
        float percent = 0;

        Vector3 initialRot = transform.localEulerAngles;
        float maxReloadAngle = 30.0f;

        while (percent < 1)
        {
            percent += Time.deltaTime * reloadSpeed;

            float interpolation = (-Mathf.Pow(percent, 2) + percent) * 4;
            float reloadAngle = Mathf.Lerp(0, maxReloadAngle, interpolation);
            transform.localEulerAngles = initialRot + Vector3.left * reloadAngle;

            yield return null;
        }

        isReloading = false;
        projectilesRemainingInMag = m_WeaponData.ProjectilesPerMag;
    }

    
}
