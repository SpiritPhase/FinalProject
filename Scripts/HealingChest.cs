using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingChest : MonoBehaviour
{
    public GameObject healingItem;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag("Player")) {
            Health playerHealth = other.GetComponent<Health>();

            if (playerHealth != null) {

                Instantiate(healingItem, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }

        }

    }
}
