using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {


 public void Collect(PlayerController playerController)
    {
        playerController.GainEnhancedShooting();
        
        Destroy(gameObject);
    }
}    