using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VsyncToggle : MonoBehaviour
{
    public Toggle vsyncToggle;
    // Start is called before the first frame update
    void Start()
    {
        vsyncToggle.isOn = QualitySettings.vSyncCount != 0;
    }
    public void OnVsyncToggle(bool isOn) {

        QualitySettings.vSyncCount = isOn ? 1 : 0;
    }
}
