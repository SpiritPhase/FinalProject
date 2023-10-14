using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform spawnPoint;
    [SerializeField] float speed = 1;
    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start() {
        if (spawnPoint == null) {

            Debug.LogWarning("Spawn point is not assigned!");
        }

    }
    public void MoveTransform(Vector3 vel) {
    transform.position += vel * Time.deltaTime;
    }

    public void MoveRB(Vector3 vel){
        rb.velocity = vel * speed;
        //rb.MovePosition(transform.position + (vel* Time.fixedDeltaTime));
        //rb. AddForce(vel);
    }


}