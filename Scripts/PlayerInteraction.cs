using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactRange = 2f; // Range within which the player can interact
    public LayerMask interactLayer; // Layer mask for objects the player can interact with
    public PlayerController playerController; // Reference to the player controller script

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }


    void TryInteract()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, interactRange, interactLayer);

        if (hit)
        {
            if (hit.collider.CompareTag("TreasureChest"))
            {
                TreasureChest treasureChest = hit.collider.GetComponent<TreasureChest>();
                if (treasureChest != null)
                {
                    Destroy(hit.collider.gameObject); 
                    treasureChest.Open(); 

                   
                    if (playerController != null)
                    {
                        playerController.GainEnhancedShooting(); 
                    }
                }
            }
        }
    }
}
