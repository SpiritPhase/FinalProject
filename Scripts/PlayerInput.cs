using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
   
   PointsHandler pointsHandler;
    ProjectileThrower projectiles;
    

    void Awake() {
    //pointsHandler = GameObject.FindGameObject("PointsHandler").GetComponent<pointsHandler>();
    //pointsHandler = GameObject.FindGameObjectWithTag("PointsHandler"),GetComponent<pointsHandler>();
    projectiles = GetComponent<ProjectileThrower>();
    }

    void Start() {
        pointsHandler = PointsHandler.singleton;
    }

    void Update() {

 if(Input.GetKeyDown(KeyCode.Q)) {
    projectiles.Throw(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
    }


}    