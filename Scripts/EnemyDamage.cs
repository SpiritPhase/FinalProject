using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 1;
    void OnTriggerEnter2D(Collider2D other) {

    if (other.CompareTag("Player")) {
    Health playerHealth = other.GetComponent<Health>();    
    if (playerHealth != null) {
        playerHealth.TakeDamage(damageAmount);
    
    }
}
    }
 
}
