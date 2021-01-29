/*
 * Chris Smith
 * Netherite Sword
 * Assignment 1
 * A class for Netherite Sword Items
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetheriteSword : Item, Breakable
{
    private int damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = 8;
    }
    
    // The inherited Use method from Item
    public override void Use()
    {
        Debug.Log("Use: The player swings their sword and if it hits a damageable entity, it deals damage to it equal to damage.");
    }

    public void GainDurability(int amount)
    {
        Debug.Log("Gain Durability: Increases the durability of the item by the amount.");
    }

    public void LoseDurability(int amount)
    {
        Debug.Log("Lose Durability: Decreases the durability of the item by the amount.");
    }
}
