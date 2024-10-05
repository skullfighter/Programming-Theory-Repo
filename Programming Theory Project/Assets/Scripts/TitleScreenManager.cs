using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Ensure you have TMPro for the TextMeshPro elements

public class PlayerNameHandler : MonoBehaviour
{
    public TMP_InputField nameInputField; // Reference to your TMP Input Field for the player name

    // This function will be called when the button is pressed
    public void OnSubmitNameAndLoadScene()
    {
        // Save the player's name from the input field
        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save(); // Save the changes

        // Optionally, you can log the name for debugging purposes
        Debug.Log("Saved Player Name: " + playerName);

        // Load the next scene (you can use the scene name or index)
        SceneManager.LoadScene(1); // Replace with your scene name or index
    }
}
