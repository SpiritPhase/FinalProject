using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundEffectsSlider : MonoBehaviour
{
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("SoundEffectsVolume", 0.5f);
        SetSoundEffectsVolume(volumeSlider.value);
    }

    public void OnVolumeChanged(float volume) {

        SetSoundEffectsVolume(volume);
    }

    private void SetSoundEffectsVolume(float volume) {

        PlayerPrefs.SetFloat("SoundEffectsVolume", volume);

    }
}
