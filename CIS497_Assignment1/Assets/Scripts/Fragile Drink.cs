using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileDrink : Item, Breakable, Drinkable
{
    public void DrinkAnimation()
    {
        Debug.Log("Plays the drinking animation.");
    }

    public void DrinkSound()
    {
        Debug.Log("Plays the drinking sound effect.");
    }

    public void GainDurability(int amount)
    {
        Debug.Log("Increases the durability of the item by the amount.");
    }

    public void LoseDurability(int amount)
    {
        Debug.Log("Decreases the durability of the item by the amount.");
    }

    public override void Use()
    {
        Debug.Log("The player drinks the item and it loses durability.");
    }
    
}
