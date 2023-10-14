using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int currentBullets;
    public int maxBullets = 20;
    public float speed = 10.0f;
    public GameObject bulletPrefab; 
    public Transform firePoint;
    private bool canShoot = true;
    bool hasPowerup = false; 

    void Start()
    {
        currentBullets = maxBullets;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && canShoot) // Assuming space is your shoot key
        {
            if (hasPowerup) {

                ShootStandard();
            }
          
        }
    }

    void ShootStandard()
    {
        if (currentBullets > 0)
        {
           Vector3 bulletDirection1 = (transform.up - transform.right).normalized;
            //First firerate
             GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
            rb1.velocity = bulletDirection1 * speed;
            if (hasPowerup) {

            Vector3 bulletDirection2 = (transform.up + transform.right).normalized;
                //Second firerate
               GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity); 
                Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
                rb2.velocity = bulletDirection2 * speed;
               
                 Vector3 combinedDirection = (bulletDirection2 + transform.right).normalized;


                rb2.velocity = combinedDirection * speed;
            }
            currentBullets--;
        }
    }

    public void GainEnhancedShooting()
    {
        if (!hasPowerup)
        {
            hasPowerup = true;
            maxBullets *= 2; 
            currentBullets = maxBullets; 
            canShoot = true;
        }
    }
}

