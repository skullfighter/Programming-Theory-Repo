using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    // Constructor
    public Sword() : base("Sword", 50, 1.5f) { } // Pass parameters to the base class constructor

    public override void DisplayStats()
    {
        base.DisplayStats(); // Call base class method to display stats
        Debug.Log("This is a melee weapon.");
    }
}
