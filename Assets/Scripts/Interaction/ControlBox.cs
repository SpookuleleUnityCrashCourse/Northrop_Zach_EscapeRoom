using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBox : MonoBehaviour, IInteractable
{
    public PlayerInput playerInput;
    public ControlData fuckyControls;

    public void OnInteract()
    {
        playerInput.controlData = fuckyControls;
    }

    public string GetPrompt()
    {
        return "Activate Fucky Controls";
    }
}
