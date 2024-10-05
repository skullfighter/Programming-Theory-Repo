using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public string weaponName;
    public int damage;
    public float range;

    public Weapon(string name, int dmg, float rng)
    {
        weaponName = name;
        damage = dmg;
        range = rng;
    }

    public virtual string GetWeaponName()
    {
        return weaponName;
    }

    public virtual void DisplayStats()
    {
        Debug.Log("Weapon: " + weaponName + ", Damage: " + damage + ", Range: " + range);
    }
}
