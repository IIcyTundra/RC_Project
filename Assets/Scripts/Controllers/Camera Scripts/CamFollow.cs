using Cinemachine;
using Hertzole.ScriptableValues;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControls : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCam;


    private void Start()
    {
         virtualCam = GetComponent<CinemachineVirtualCamera>();
        GetPlayer();

    }

    private void GetPlayer()
    {
        if(GameObject.FindWithTag("Player"))
        {
            virtualCam.Follow = GameObject.FindWithTag("Player").transform;
            return;
        }
    }

}
