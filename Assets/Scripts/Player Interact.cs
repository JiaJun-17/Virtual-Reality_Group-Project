using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private GameObject dialogueContainerGameObject;
    private NPCInteractable currentInteractable;
    // Update is called once per frame
    private void Update()
    {

        NPCInteractable interactable = GetInteractableObject();

        if (interactable != currentInteractable)
        {
            if (currentInteractable != null)
            {
                HideDialogue();
            }

            currentInteractable = interactable;
        }

        if (currentInteractable != null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                currentInteractable.ShowDialogue();
                currentInteractable.Interact();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                HideDialogue();
            }
        }
        else
        {
            HideDialogue();
        }
    }

    public void HideDialogue()
    {
        dialogueContainerGameObject.SetActive(false);
    }

    public NPCInteractable GetInteractableObject()
    {
        List<NPCInteractable> npcInteractableList = new List<NPCInteractable>();
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out NPCInteractable npcInteractable))
            {
                npcInteractableList.Add(npcInteractable);

            }

        }
        NPCInteractable closestNPCInteractable = null;
        foreach (NPCInteractable npcInteractable in npcInteractableList)
        {
            if (closestNPCInteractable == null)
            {
                closestNPCInteractable = npcInteractable;
            }
            else
            {
                if (Vector3.Distance(transform.position, npcInteractable.transform.position) <
                    Vector3.Distance(transform.position, closestNPCInteractable.transform.position))
                {
                    closestNPCInteractable = npcInteractable;
                }

            }
        }
        return closestNPCInteractable;
    }
}
