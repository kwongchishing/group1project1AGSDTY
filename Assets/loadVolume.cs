using UnityEngine;using UnityEngine.UI;public class loadVolume:MonoBehaviour{
    public Slider slider;
    void Start(){
        if (PlayerPrefs.HasKey("Volume")){
            slider.value=PlayerPrefs.GetFloat("Volume");
            AudioListener.volume = slider.value;
        }
        else{
            slider.value=1;
        }
    }
}