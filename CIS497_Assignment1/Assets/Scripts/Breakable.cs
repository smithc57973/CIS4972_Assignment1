/*
 * Chris Smith
 * Breakable
 * Assignment 1
 * An interface for breakable items.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Breakable
{
    //Increases the durability of the item by the amount
    void GainDurability(int amount);

    //Decreases the durability of the item by the amount
    void LoseDurability(int amount);
}
