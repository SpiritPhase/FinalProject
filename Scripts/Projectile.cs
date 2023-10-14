using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 1;
    public int damageAmount = 1;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DestructibleWall")) {
            DestructibleWall wall = other.GetComponent<DestructibleWall>();
        if (wall != null) {
            wall.TakeDamage(damageAmount);
            Destroy(gameObject);
        }
 }
        ZombieMove enemy = other.GetComponent<ZombieMove>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}


   

