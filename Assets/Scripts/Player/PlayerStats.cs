using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hertzole.ScriptableValues;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    //Stats 
    public ScriptableFloat WalkSpeed;
    public ScriptableFloat DashSpeed;
    public ScriptableFloat PickupRange;
    public ScriptableFloat Health;
    public ScriptableFloat Stamina;


}
