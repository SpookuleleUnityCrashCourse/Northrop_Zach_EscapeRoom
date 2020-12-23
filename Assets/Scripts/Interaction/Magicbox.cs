using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magicbox : MonoBehaviour, IInteractable
{
    public ParticleSystem particles;
    
    public void OnInteract()
    {
        particles.Play();
    }

    public string GetPrompt()
    {
        return "Start Magic";
    }
}
