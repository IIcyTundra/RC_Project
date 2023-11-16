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
public abstract class Item
{
    public string ItenName;
    public Sprite ItemSprite;
    [TextArea] public string Description;
    public ItemRarity Rarity;
    public int ItemWeight;
    public int MaxStacks;

    public virtual void Update(PlayerInfo player, int stacks)
    {

    }
    public virtual void OnHit(PlayerInfo player, int stacks)
    {

    }

}
public class BoonOfLight : Item
{
    float internalCoolDown;
    GameObject effect;

    public override void Update(PlayerInfo player, int stacks)
    {
        internalCoolDown -= 1;

        if(internalCoolDown <= 0)
        {
            if (effect == null) effect = (GameObject)Resources.Load("ItemEffects/HealingArea", typeof(GameObject));
            internalCoolDown = 11 - stacks; 
        }
    }
}


