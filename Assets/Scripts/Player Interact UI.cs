using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject promptContainerGameObject;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] private TextMeshProUGUI promptTMP;

    private void Update()
    {
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }
        else
        {
            HidePrompt();
        }
    }

    private void Show(NPCInteractable npcInteractable)
    {
        promptContainerGameObject.SetActive(true);
        promptTMP.text = npcInteractable.GetPromptText();
    }

    private void HidePrompt()
    {
        promptContainerGameObject.SetActive(false);
    }
}
