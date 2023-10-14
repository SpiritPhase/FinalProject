using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float maxHeight = 10.0f;
    public float minHeight = 0.0f;

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newY = transform.position.y + moveSpeed * Time.deltaTime * direction;
        newY = Mathf.Clamp(newY, minHeight, maxHeight);

         if (newY == maxHeight || newY == minHeight) {
            direction *= -1;
        }
transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
