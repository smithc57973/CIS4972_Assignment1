/*
 * Chris Smith
 * Drinkable
 * Assignment 1
 * An interface for drinkable items.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Drinkable
{
    //Plays the drinking animation
    void DrinkAnimation();

    //Plays the drinking sound effect
    void DrinkSound();
}
