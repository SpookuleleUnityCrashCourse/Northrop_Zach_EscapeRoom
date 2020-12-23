using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedbox : MonoBehaviour, IInteractable
{

    public Player player;
    public PlayerData powerUpData;
    

    public void OnInteract()
    {
        player.playerData = powerUpData;
    }

    public string GetPrompt()
    {
        return "Give Super Speed";
    }
}
