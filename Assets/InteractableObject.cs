using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject InteractPrompt;

    private bool CanPickUp;
    private void OnEnable()
    {
        InteractPrompt.SetActive(false);
        CanPickUp = false;
    }


    public void OnInteract()
    {
        if(CanPickUp)
        {
            InteractEvent();
        }
           
    }

    public virtual void InteractEvent() { }
}
