using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerInteractable : MonoBehaviour
{
    [SerializeField] private string promptText;
    [SerializeField] private string dialogue;
    public Transform target;

    public void Interact()
    {
        Debug.Log("Speaker Interact!");
        // No transform.LookAt(target); here since the NPC should not face the player
    }

    public string GetPromptText()
    {
        return promptText;
    }

    public string GetDialogue()
    {
        return dialogue;
    }

    // No ShowDialogue and HideDialogue methods since no dialogue box should appear
}
