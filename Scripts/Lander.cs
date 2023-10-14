using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lander : MonoBehaviour
{
  Rigidbody2D rb;
    [SerializeField] int hp = 40;
    [SerializeField] GameObject Gun;
    [SerializeField] float speed = 1;

    // Start is called before the first frame update

    void Awake(){ 
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        CopyGunColor();
    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speed * Time.deltaTime,0,0);
        }
         if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,speed * Time.deltaTime,0);
         }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= new Vector3(0,speed * Time.deltaTime,0);
        }
}
public void CopyGunColor() {
Gun.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
}

public int GetHP() {
    return hp; 
}

}
