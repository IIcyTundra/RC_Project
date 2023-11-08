using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour, IInteractable
{
    [SerializeField] private PlayerInputEvents m_PlayerInput;
    [SerializeField] private CircleCollider2D m_PickupRange;
    [SerializeField] private GameObject InteractPrompt;

    private bool CanPickUp;
    private void OnEnable()
    {
        InteractPrompt.SetActive(false);
        CanPickUp = false;
        m_PlayerInput.InteractEvent += OnInteract;
    }


    public void OnInteract()
    {
        if(CanPickUp)
            gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Is within range");
            CanPickUp = true;
            InteractPrompt.SetActive(true);
        }
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InteractPrompt.SetActive(false);
            CanPickUp = false;
        }
            
    }
}
