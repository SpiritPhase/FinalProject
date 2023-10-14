using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallDelay = 1f;
    public float fallSpeed = 10f;

    private bool hasPlayerLanded = false;

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("Player") && !hasPlayerLanded) {
            hasPlayerLanded = true;
            Invoke("Fall", fallDelay);
        }
    }
    private void Fall() {
    Rigidbody2D rb = GetComponent<Rigidbody2D>();
    if (rb != null) {
        rb.isKinematic = false;
        rb.velocity = new Vector2(0, -fallSpeed);
    }
    
}

}
