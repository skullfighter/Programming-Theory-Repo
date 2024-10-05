using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPlayerInfo : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI weaponInfoText;

    void Start()
    {
        // Display Player Name
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;

        // Display Selected Weapon Info
        string selectedWeapon = PlayerPrefs.GetString("SelectedWeapon");
        int weaponDamage = PlayerPrefs.GetInt("WeaponDamage");
        float weaponRange = PlayerPrefs.GetFloat("WeaponRange");

        // Combine the information into one string
        weaponInfoText.text = $"You have selected: {selectedWeapon}\n" +
                              $"Damage: {weaponDamage}\n" +
                              $"Range: {weaponRange}";
    }
}
