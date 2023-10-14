using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
  public void PlayGame() {
    SceneManager.LoadScene("LanderPlayGround");

  }

public void QuitGame() {
Debug.Log("QUIT!");
Application.Quit();
    
    }   

  public void Options() {
    SceneManager.LoadScene("Options");


  }

}
