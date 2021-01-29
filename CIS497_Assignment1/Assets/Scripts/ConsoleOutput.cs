/*
 * Chris Smith
 * ConsoleOutput
 * Assignment 1
 * A script that manages the ingame console messages.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    List<Item> items = new List<Item>();
    List<Drinkable> drinkables = new List<Drinkable>();
    List<Breakable> breakables = new List<Breakable>();

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(sword);
        //Instantiate(potion);
        NetheriteSword sword = new NetheriteSword();
        Debug.Log("==Netherite Sword==");
        sword.Use();
        sword.GainDurability(1);
        sword.LoseDurability(1);

        PotionofHealing potion = new PotionofHealing();
        Debug.Log("==Potion of Healing==");
        potion.Use();
        potion.DrinkAnimation();
        potion.DrinkSound();


        //Add objects
        items.Add(new NetheriteSword());
        items.Add(new NetheriteSword());
        items.Add(new PotionofHealing());
        items.Add(new PotionofHealing());
        breakables.Add(new NetheriteSword());
        drinkables.Add(new PotionofHealing());

        //new concrete class
        FragileDrink drink = new FragileDrink();
        Debug.Log("==Fragile Drink==");
        drink.Use();
        drink.GainDurability(1);
        drink.LoseDurability(1);
        drink.DrinkAnimation();
        drink.DrinkSound();

        items.Add(new FragileDrink());
        breakables.Add(new FragileDrink());
        drinkables.Add(new FragileDrink());
    }

    // Update is called once per frame
    void Update()
    {

        //if player presses 1, calls the use methods for all items in list
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Item i in items)
            {
                Debug.Log("==" + i + "==");
                i.Use();
            }
        }

        //if player presses 2, calls the interface methods for all items in list
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Breakable b in breakables)
            {
                Debug.Log("==" + b + "==");
                b.GainDurability(1);
                b.LoseDurability(1);
            }

            foreach (Drinkable d in drinkables)
            {
                Debug.Log("==" + d + "==");
                d.DrinkAnimation();
                d.DrinkSound();
            }
        }

    }
}
