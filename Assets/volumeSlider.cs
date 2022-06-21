using UnityEngine;using UnityEngine.UI;public class volumeSlider:MonoBehaviour{public Slider slider;
    public void changeVolume(){
        AudioListener.volume=slider.value;}
    public void backnotsaveVolume(){
        if(PlayerPrefs.HasKey("Volume")){slider.value=PlayerPrefs.GetFloat("Volume");}
        else{slider.value=1;}}
    public void saveVolume(){
        AudioListener.volume=slider.value;
        PlayerPrefs.SetFloat("Volume",slider.value);}}