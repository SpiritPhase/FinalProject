using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; 
            pauseMenuUI.SetActive(true); 
        }
        else
        {
            Time.timeScale = 1; 
            pauseMenuUI.SetActive(false); 
        }
    }
    public void ResumeGame()
{
    Time.timeScale = 1;
    pauseMenuUI.SetActive(false); 
}

public void OpenOptions()
{
    
}

public void QuitGame()
{
    

    Application.Quit(); 
}

}

