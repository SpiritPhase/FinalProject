using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawner : MonoBehaviour
{
public GameObject crystalPrefab;
public float respawnTime = 1.0f;
private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
     screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.x));     
     StartCoroutine(crystalWave());   
    }
private void spawnCrystalion() {

    GameObject a = Instantiate(crystalPrefab) as GameObject;
    a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
}
IEnumerator crystalWave() {

    while (true) {

        yield return new WaitForSeconds(respawnTime);
        spawnCrystalion();

    }
}
}