using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualSettings : MonoBehaviour
{
    public Slider brightnessSlider;
    public Slider contrastSlider;
    public Slider colorationSlider;

   



    // Start is called before the first frame update
    void Start()
    {

        brightnessSlider.value = PlayerPrefs.GetFloat("Brightness", 0.5f);
        contrastSlider.value = PlayerPrefs.GetFloat("Contrast", 0.5f);
        colorationSlider.value = PlayerPrefs.GetFloat("Coloration", 0.5f);


        ApplyVisualSettings();
    }

public void OnBrightnessChanged(float brightness) {
    PlayerPrefs.SetFloat("Brightness", brightness);
      ApplyVisualSettings();
}
    public void OnContrastChanged(float contrast) {
    PlayerPrefs.SetFloat("Contrast", contrast);
      ApplyVisualSettings();

}
public void OnColorationChanged(float coloration) {
    PlayerPrefs.SetFloat("Coloration", coloration);
      ApplyVisualSettings();
}

private void ApplyVisualSettings() {


}
}
