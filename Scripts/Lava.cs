using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {

            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null) {

                playerHealth.TakeDamage(damageAmount);
        }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
