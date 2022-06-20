using UnityEngine;public class backspaceclosevolumenotsave:MonoBehaviour{
    public volumeSlider volumeSlider;
    public settingfunction settingfunction;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace)||Input.GetKeyDown(KeyCode.Q)){
            volumeSlider.backnotsaveVolume();
            settingfunction.VolumepressSave();
        }
    }
}