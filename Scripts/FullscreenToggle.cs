using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FullscreenToggle : MonoBehaviour
{

    public Toggle fullscreenToggle;
    // Start is called before the first frame update
    void Start()
    {
        fullscreenToggle.isOn = Screen.fullScreen;
    }
    public void OnFullScreenToggle(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
