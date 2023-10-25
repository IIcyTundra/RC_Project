using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform[] weapons;

    [Header("Keys")]
    [SerializeField] private KeyCode[] keys;

    [Header("Settings")]
    [SerializeField] private float switchTime;

    private int selectedWeapon;
    private float timeSinceLastSwitch;

    public Camera m_playerCam;

    public static Action ShootInputDown;
    public static Action ShootInputUp;

    private void Start()
    {
        SetWeapons();
        Select(selectedWeapon);

        timeSinceLastSwitch = 0f;
    }

    private void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            ShootInputDown?.Invoke();
        }

        if(Input.GetMouseButtonUp(0)) 
        {
            ShootInputUp?.Invoke();
        }
        SwapCurrentWeapon();
        WeaponAiming();

    }

    #region Weapon Controls

    
    private void WeaponAiming()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = m_playerCam.ScreenToWorldPoint(mousePos);

        Vector2 direction = (mousePos - weapons[selectedWeapon].position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply rotation to the gun
        weapons[selectedWeapon].rotation = Quaternion.Euler(0, 0, angle);

        // Flip the gun based on rotation
        weapons[selectedWeapon].GetComponentInChildren<SpriteRenderer>().flipY = Mathf.Abs(angle) > 90;
    }

    #endregion

    #region Weapon Swapping

    private void SwapCurrentWeapon()
    {
        int previousSelectedWeapon = selectedWeapon;

        for (int i = 0; i < keys.Length; i++)
            if (Input.GetKeyDown(keys[i]) && timeSinceLastSwitch >= switchTime)
                selectedWeapon = i;

        if (previousSelectedWeapon != selectedWeapon) Select(selectedWeapon);

        timeSinceLastSwitch += Time.deltaTime;
    }
    private void SetWeapons()
    {
        weapons = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            weapons[i] = transform.GetChild(i);

        if (keys == null) keys = new KeyCode[weapons.Length];
    }

    private void Select(int weaponIndex)
    {
        for (int i = 0; i < weapons.Length; i++)
            weapons[i].gameObject.SetActive(i == weaponIndex);

        timeSinceLastSwitch = 0f;

        OnWeaponSelected();
    }

    #endregion

    private void OnWeaponSelected() { }
}
