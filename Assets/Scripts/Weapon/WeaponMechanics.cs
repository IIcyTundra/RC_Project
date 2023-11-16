using Hertzole.ScriptableValues;
using Kitbashery.Gameplay;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class WeaponMechanics : MonoBehaviour
{
    [SerializeField] private WeaponData m_WeaponData;
    [SerializeField] private Transform[] WeaponMuzzles;
    [SerializeField] private ScriptableStringEvent onAmmoChanged;
    [SerializeField] private ScriptableIntEvent onAmmoGrabbed;

    [SerializeField] private PlayerInputEvents m_PlayerInput;

    private float timeBetweenShots;

    Vector3 recoilSmoothDampVelocity;
    float recoilRotSmoothDampVelocity;
    float recoilAngle;


    float nextShotTime;
    bool triggerReleasedSinceLastShot;
    int shotsRemainingInBurst;
    int projectilesRemainingInMag;
    int currentAmmoTotal;

    public bool isShooting;

    AudioSource source;
    private bool isReloading;

    private void OnEnable()
    {
        m_PlayerInput.PrimaryFirePressedEvent += OnTriggerHold;
        m_PlayerInput.PrimaryFireReleasedEvent += OnTriggerReleased;

        onAmmoChanged.Invoke(this, $"{projectilesRemainingInMag} | {m_WeaponData.AmmoCapacity}");
        onAmmoGrabbed.OnInvoked += OnAmmoPickup;

    }



    private void OnDisable()
    {
        m_PlayerInput.PrimaryFirePressedEvent -= OnTriggerHold;
        m_PlayerInput.PrimaryFireReleasedEvent -= OnTriggerReleased;

        onAmmoGrabbed.OnInvoked -= OnAmmoPickup;

    }


    private void Start()
    {
        currentAmmoTotal = m_WeaponData.AmmoCapacity;
        nextShotTime = Time.time;
        shotsRemainingInBurst = m_WeaponData.burstCount;
        projectilesRemainingInMag = m_WeaponData.ProjectilesPerMag;
        source = GetComponentInParent<AudioSource>();
        timeBetweenShots = 1.0f / m_WeaponData.RateOfFire;
    }

    private bool CanShoot() => (!isReloading && Time.time >= nextShotTime && projectilesRemainingInMag > 0);

    public void Shoot()
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
            SpawnProjectile();



            int j = Random.Range(0, m_WeaponData.ShootAudio.Length);
            source.PlayOneShot(m_WeaponData.ShootAudio?[j]);

            projectilesRemainingInMag--;

            onAmmoChanged.Invoke(this, $"{projectilesRemainingInMag} | {currentAmmoTotal}");


        }

    }


    private void SpawnProjectile()
    {
        foreach (Transform muzzle in WeaponMuzzles)
        {
            GameObject bullet = ObjectPools.Instance.GetPooledObject(m_WeaponData.BulletPrefab.name);
            if (bullet.activeSelf != true)
            {
                bullet.transform.SetPositionAndRotation(muzzle.position, muzzle.rotation);

                bullet.SetActive(true);

                bullet.transform.forward = muzzle.forward;
            }
        }
    }



    private void OnAmmoPickup(object sender, int e)
    {

        if ((currentAmmoTotal += e) > m_WeaponData.AmmoCapacity)
        {
            currentAmmoTotal = m_WeaponData.AmmoCapacity;
        }
        else
        {
            currentAmmoTotal += e;
        }


    }

    public void OnTriggerHold()
    {
        Shoot();
        triggerReleasedSinceLastShot = false;
    }

    public void OnTriggerReleased()
    {
        triggerReleasedSinceLastShot = true;
        shotsRemainingInBurst = m_WeaponData.burstCount;
        isShooting = false;
    }
}


