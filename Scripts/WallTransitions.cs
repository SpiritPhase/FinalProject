using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WallTransitions : MonoBehaviour
{
    public string targetSceneName;
    public Transform playerSpawnPoint;
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {

            SceneManager.LoadScene(targetSceneName);
            SetPlayerSpawnPoint();
        }
    }


    private void SetPlayerSpawnPoint() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null && playerSpawnPoint != null) {

            player.transform.position = playerSpawnPoint.position;
        }
        else {

            Debug.LogWarning("Player or spawn point not found!");
        }

    }
}
