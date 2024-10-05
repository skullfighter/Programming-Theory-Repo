using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelectionManager : MonoBehaviour
{
    private Weapon selectedWeapon;

    public void SelectSword()
    {
        selectedWeapon = new Sword(); // Instantiate Sword
        EquipWeapon();
        LoadNextScene();
    }

    public void SelectBow()
    {
        selectedWeapon = new Bow(); // Instantiate Bow
        EquipWeapon();
        LoadNextScene();
    }

    private void EquipWeapon()
    {
        // Log selected weapon details
        Debug.Log("Equipped: " + selectedWeapon.GetWeaponName());
        selectedWeapon.DisplayStats();

        // Save the selected weapon name for the next scene
        PlayerPrefs.SetString("SelectedWeapon", selectedWeapon.GetWeaponName());
        PlayerPrefs.SetInt("WeaponDamage", selectedWeapon.damage);
        PlayerPrefs.SetFloat("WeaponRange", selectedWeapon.range);
    }

    private void LoadNextScene()
    {
        // Load the new scene after weapon selection
        SceneManager.LoadScene(2);  // Replace with your scene index or name
    }
}
