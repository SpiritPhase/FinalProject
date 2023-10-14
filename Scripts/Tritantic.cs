using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tritantic : MonoBehaviour
{
  public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootForce = 10f;
    public float shootInterval = 2f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("Shoot", 0f, shootInterval);
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        Vector2 direction = (player.position - shootPoint.position).normalized;
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = direction * shootForce;

        Destroy(projectile, 2f); 
    }
}
