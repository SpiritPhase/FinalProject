using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDissapear : MonoBehaviour
{

     public float disappearTime = 1.0f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disappear", disappearTime);
    }

    void Disappear() {
    Destroy(gameObject);
 }
public void TakeDamage(float Damage)
{
    if (gameObject != null)
    Destroy(gameObject);    
}
void Update() {
 
 if (Input.GetButtonDown("Fire1")) {
GameObject newProjectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

 }
}
}