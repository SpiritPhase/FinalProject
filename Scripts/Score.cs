using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
 public Text MyscoreText;
    private int scoreValue;
    void Start() {
        scoreValue = 0;
        MyscoreText.text = "Score: " + scoreValue;
    }
    private void OnTriggerEnter2D(Collider2D Crystalions) {
        if(Crystalions.tag == "MyCrystal") {
            scoreValue += 1;
            Destroy(Crystalions.gameObject);
            MyscoreText.text = "Score: " + scoreValue;
            GetComponent<AudioSource>().Play();
        }



    }
}