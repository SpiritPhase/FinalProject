using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicLevels : MonoBehaviour
{
    public Slider volumeSlider;


    void Start() {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        SetMusicVolume(volumeSlider.value);

    }
    public void OnVolumeChanged(float volume) {

        SetMusicVolume(volume);
    }


private void SetMusicVolume(float volume) {

    PlayerPrefs.SetFloat("MusicVolume", volume);
    AudioListener.volume = volume;

}
}
