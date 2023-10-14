using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerInput : MonoBehaviour
{
    [SerializeField] PlatformerCharacter pc;
     PointsHandler pointsHandler;
 ProjectileThrower projectiles;

    void Awake(){
    projectiles = GetComponent<ProjectileThrower>();
    }

    void Start() {
    pointsHandler = PointsHandler.singleton;


    }
    void Update(){

    

    if(Input.GetKeyDown(KeyCode.Q)) {
    projectiles.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
        if(Input.GetKey(KeyCode.A)){
            pc.Move(new Vector3(-1,0,0));
        }else if(Input.GetKey(KeyCode.D)){
            pc.Move(new Vector3(1,0,0));    
        }else{
            pc.Stop();
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
        pc.Jump();   
        }

    }
}
