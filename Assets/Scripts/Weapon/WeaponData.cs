using UnityEngine;


public enum FireMode
{
    Single,
    Burst,
    Automatic
}

public enum AmmoType
{
    Light,
    Heavy,
    Special
}


[CreateAssetMenu(fileName = "WeaponData", menuName = "Weapon System/Weapon Data")]
public class WeaponData : ScriptableObject
{

    [Header("Stats")]
    public float MuzzleVelocity;
    public FireMode fireMode = FireMode.Single;
    public int burstCount = 1;
    public float RateOfFire;
    public float NumberOfBullets;
    public float SpreadAngle;
    public int AmmoCapacity;
    public AmmoType ammoType;

    [Header("Projectile")]
    public GameObject BulletPrefab;
    [Header("MuzzleFlash")]
    public GameObject FlashPrefab;

    [Header("Effects")]
    public AudioClip[] ShootAudio;
    public AudioClip EmptyMagAudio;
    public AudioClip ReloadAudio;

    [Header("Recoil")]
    public Vector2 kickMinMax = new Vector2(.05f, .2f);
    public Vector2 recoilAngleMinMax = new Vector2(3, 5);
    public float recoilMoveSettleTime = .1f;
    public float recoilRotationSettleTime = .1f;

}