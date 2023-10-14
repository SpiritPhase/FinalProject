using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
   public int damageAmount = 1;

   void OnTriggerEnter2D(Collider2D other) {

    if (other.CompareTag("Player")) {
        other.GetComponent<Health>().TakeDamage(damageAmount);

        
     }

   }  
}
