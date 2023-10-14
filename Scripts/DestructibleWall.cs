using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
  public int health = 3;

  public void TakeDamage(int damageAmount) {

    health -= damageAmount;

    if (health <= 0) {
        Destroy(gameObject);
    }
  }
}
