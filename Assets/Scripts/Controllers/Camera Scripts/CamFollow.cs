using Hertzole.ScriptableValues;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControls : MonoBehaviour
{
    [SerializeField] private ScriptableFloat CamZoom;
    [SerializeField] private ScriptableFloat CamFollowSpeed;
    [SerializeField] private ScriptableFloat CamOffset;
    [SerializeField] private ScriptableFloat CamShakeIntensity;
    [SerializeField] private ScriptableFloat CamShakeMagnitude;
    [SerializeField] private Transform target;


    private void Start()
    {
        transform.position = target.position;
    }
    void Update()
    {
        if(target != null)
            FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + CamOffset.Value, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, CamFollowSpeed.Value * Time.deltaTime);
    }
}
