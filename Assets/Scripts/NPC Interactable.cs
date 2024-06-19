using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{

    [SerializeField] private string promptText;
    [SerializeField] private string dialogue;
    public Transform target;
    [SerializeField] private GameObject containerGameObject2;
    [SerializeField] private TextMeshProUGUI dialogueTMP;
    public void Interact()
    {
        Debug.Log("Interact!");
        transform.LookAt(target);
    }

    public string GetPromptText()
    {
        return promptText;
    }

    public string GetDialogue()
    {
        return dialogue;
    }

    public void ShowDialogue()
    {
        containerGameObject2.SetActive(true);
        dialogueTMP.text = GetDialogue();
    }

    public void HideDialogue()
    {
        containerGameObject2.SetActive(false);
    }
}
