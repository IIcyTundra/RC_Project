using UnityEngine;

[CreateAssetMenu(fileName = "AmmoData", menuName = "Ammo Data")]

public class AmmoData : ScriptableObject
{
    public AmmoType AmmoType;
    public int AmmoAmount;


#if UNITY_EDITOR
    private void OnValidate()
    {
        // Automatically set AmmoAmount based on AmmoType when in the Unity Editor
        switch (AmmoType)
        {
            case AmmoType.Light:
                AmmoAmount = 100;
                break;
            case AmmoType.Special:
                AmmoAmount = 20;
                break;
            case AmmoType.Heavy:
                AmmoAmount = 2;
                break;
            default:
                AmmoAmount = 0;
                break;
        }
    }
#endif
}

