using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResolutionDropdown : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
       PopulateResolutionDropdown();
    }       
        void PopulateResolutionDropdown() {
    List<string> options = new List<string>();
    Resolution[] resolutions = Screen.resolutions;
foreach (Resolution resolution in resolutions ) {
     string option = (resolution.width + "x" + resolution.height); 
        options.Add(option);
    }
   resolutionDropdown.ClearOptions();     
   resolutionDropdown.AddOptions(options);     
        
   int currentResolutionIndex = GetCurrentResolutionIndex();
    resolutionDropdown.value = currentResolutionIndex;
     resolutionDropdown.RefreshShownValue();     
 }
    private int GetCurrentResolutionIndex() {

    Resolution currentResolution = Screen.currentResolution;
    Resolution[] resolutions = Screen.resolutions;
    for (int i = 0; i < resolutions.Length; i++) {

        if (resolutions[i].width == currentResolution.width && resolutions[i].height == currentResolution.height) {

            return i;
        }
    }
return 0;
}    
        
public void OnResolutionChanged(int index) {

    ApplyResolution(index);
}



private void ApplyResolution( int index) {
    Resolution[] resolutions = Screen.resolutions;
    if(index >= 0 && index < resolutions.Length) {
    Resolution selectedResolution = resolutions[index];
    Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreen);
    }

}
}