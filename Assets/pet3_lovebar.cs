using UnityEngine;using UnityEngine.UI;public class pet3_lovebar:MonoBehaviour{
    public lovexp3 lovexp;
    public Image fillImage;
    Slider slider;
    void Start(){
        lovexp.currentLove=0;
        lovexp.maxLove=500;slider=GetComponent<Slider>();
        lovexp.currentLove=PlayerPrefs.GetFloat("currentLove3");
    }
    void Update(){
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=lovexp.currentLove/lovexp.maxLove;
        slider.value=fillValue;
    }
}