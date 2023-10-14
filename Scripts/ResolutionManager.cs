using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    private int screenWidth;
    private int screenHeight;
    private bool isFullscreen;

void Start() {
    LoadResolutionSetings();
}
   public void SetResolution(int width, int height, bool fullscreen) {
    screenWidth = width;
    screenHeight = height;
    isFullscreen = fullscreen;
    
    ApplyResolution();
   }

private void ApplyResolution() {

    Screen.SetResolution(screenWidth, screenHeight, isFullscreen);
    SaveResolutionSettings();
}

private void LoadResolutionSetings() {
screenHeight = PlayerPrefs.GetInt("ScreenWidth", Screen.currentResolution.width);
screenWidth = PlayerPrefs.GetInt("ScreenHeight", Screen.currentResolution.height);
isFullscreen = PlayerPrefs.GetInt("IsFullscreen", Screen.fullScreen ? 1 : 0) == 1;

ApplyResolution();

}

private void SaveResolutionSettings() {
PlayerPrefs.GetInt("ScreenWidth", screenWidth);
PlayerPrefs.GetInt("ScreenHeight",screenHeight);
PlayerPrefs.GetInt("IsFullscreen",isFullscreen ? 1 : 0);
PlayerPrefs.Save();
}

}
