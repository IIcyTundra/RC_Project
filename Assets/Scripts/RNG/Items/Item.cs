using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public enum ItemRarity
{
    common,
    rare,
    epic,
    legendary
}


[System.Serializable]
public class Item
{
    public string Name;
    public float StatIncrease;
    public ItemRarity ItemRarity;

    public Item (string name, float statIncrease, ItemRarity itemRarity)
    {
        Name = name;
        StatIncrease = statIncrease;
        ItemRarity = itemRarity;
    }
}

[CreateAssetMenu(menuName = "Player Item")]
public class PlayerItemGenration : ScriptableObject
{
    public Item Item;
    public PlayerStats pStats;

    private void GenerateRandomPlayerItem()
    {
        Item.ItemRarity.Equals(Random.Range(0, 3));

        

        pStats.PickupRange.Value = 89;
    }
}
