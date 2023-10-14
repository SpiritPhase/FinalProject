using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public int healingAmount = 1;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {

             Health playerHealth = other.GetComponent<Health>();    
        if (playerHealth != null) {
            playerHealth.Heal(healingAmount);
            Destroy(gameObject);
        }
    }
}
}