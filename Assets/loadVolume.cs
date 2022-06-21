using UnityEngine;using UnityEngine.UI;public class loadVolume:MonoBehaviour{
    public Slider slider;
    void Start(){
        if(PlayerPrefs.HasKey("Volume")){
            slider.value=PlayerPrefs.GetFloat("Volume");
        }
        else{
            slider.value=1;
        }
    }
}