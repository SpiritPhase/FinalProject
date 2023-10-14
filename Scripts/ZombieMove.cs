using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public LayerMask groundLayerMask;
  public int maxHealth = 3;
  private int currentHealth;


  private ZombieSpawner zombie;

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Transform player;   


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentHealth = maxHealth;
    }
public void SetSpawner(ZombieSpawner zombie)
    {
        this.zombie = zombie;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    
    void Die()
    {

        if (zombie != null)
        {
            zombie.ReplaceEnemy();
            
        }
        Destroy(gameObject);
    }
void Update() {
RaycastHit hit;

    Vector3 raycastOrigin = transform.position;

    Vector3 raycastDirection = -Vector3.up;


    float raycastLength = 10f;


    if (Physics.Raycast(raycastOrigin, raycastDirection,  out hit, raycastLength, groundLayerMask)) {
        transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
    
        transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
   
    }      
        Vector3 moveDirection = (player.position - transform.position).normalized;
        transform.Translate(moveDirection * speed * Time.deltaTime);

    }

}