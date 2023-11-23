using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiscRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private bool YorZ;


    private void Update()
    {
        if (YorZ)
            transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime, Space.Self);
        else
            transform.Rotate(transform.up * rotateSpeed * Time.deltaTime);

    }
}
