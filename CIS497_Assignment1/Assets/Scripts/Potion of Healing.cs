/*
 * Chris Smith
 * Potion of Healing
 * Assignment 1
 * A class for Potion of Healing Items
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionofHealing : Item, Drinkable
{
    private int amountHealed;

    // Start is called before the first frame update
    void Start()
    {
        amountHealed = 4;
    }

    // The inherited Use method from Item
    public override void Use()
    {
        Debug.Log("Use: The player would drink the potion and gain health up to their maximum equal to amountHealed.");
    }

    public void DrinkAnimation()
    {
        Debug.Log("Drink Animation: Plays the drinking animation.");
    }

    public void DrinkSound()
    {
        Debug.Log("Drink Sound: Plays the drinking sound effect.");
    }
}
