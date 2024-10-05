using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    // Constructor
    public Bow() : base("Bow", 35, 15f) { } // Pass parameters to the base class constructor

    public override void DisplayStats()
    {
        base.DisplayStats(); // Call base class method to display stats
        Debug.Log("This is a ranged weapon.");
    }
}
