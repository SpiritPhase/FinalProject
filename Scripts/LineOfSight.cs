using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{

    public LayerMask obstacleMask;
    public float maxDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, maxDistance, obstacleMask);

        if (hit.collider != null) {

            Debug.Log("Obstacle detected!");
        }
    }
}
