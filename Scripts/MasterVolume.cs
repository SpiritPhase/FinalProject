using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MasterVolume : MonoBehaviour
{
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.value = AudioListener.volume;
    }

public void OnVolumeChanged(float volume) {

    AudioListener.volume = volume;
}
    
}
