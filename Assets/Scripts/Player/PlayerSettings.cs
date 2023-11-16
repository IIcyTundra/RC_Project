using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hertzole.ScriptableValues;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player Settings")]
public class PlayerSettings : ScriptableObject
{
    //Camera Settings
    public ScriptableFloat CamZoom;
    public ScriptableFloat CamFollowSpeed;
    public ScriptableFloat CamOffset;
    public ScriptableFloat CamShakeIntensity;
    public ScriptableFloat CamShakeMagnitude;

    //Accessiblity Settings
    [Range(0.01f, 1f)] public ScriptableFloat GameSpeed;
    [Range(0f, 100f)] public ScriptableFloat ReduceDamageIntake;
    public ScriptableBool InfiniteStamina;

}
