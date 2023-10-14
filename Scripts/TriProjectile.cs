using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriProjectile : MonoBehaviour
{
    public int damage = 1;
    
    void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag("Player")) {
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null) {
                playerHealth.TakeDamage(damage);

            }
            Destroy(gameObject);
        }


    }
        
    }

