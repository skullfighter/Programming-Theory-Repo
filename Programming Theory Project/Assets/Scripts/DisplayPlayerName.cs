using UnityEngine;
using TMPro;

public class DisplayPlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = "Welcome, " + playerName + "!";
    }
}
