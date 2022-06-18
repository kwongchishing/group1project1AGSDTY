using UnityEngine;using UnityEngine.UI;public class loadVolume:MonoBehaviour{
    public Slider slider;
    void Start(){
        if(PlayerPrefs.HasKey("Volume")){
            slider.value=PlayerPrefs.GetFloat("Volume");
        }
        else{
            slider.value=AudioListener.volume;
        }
      //  PlayerPrefs.SetFloat("Volume",slider.value);
    }
}