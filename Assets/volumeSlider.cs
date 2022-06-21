using UnityEngine;using UnityEngine.UI;public class volumeSlider:MonoBehaviour{public Slider slider;
    public void changeVolume(){
        AudioListener.volume=slider.value;}
    public void backnotsaveVolume(){
        if(PlayerPrefs.HasKey("Volume")){slider.value=PlayerPrefs.GetFloat("Volume"); AudioListener.volume=slider.value; }
        else{slider.value=1; AudioListener.volume = slider.value; }
    }
    public void saveVolume(){
        PlayerPrefs.SetFloat("Volume",AudioListener.volume);}}