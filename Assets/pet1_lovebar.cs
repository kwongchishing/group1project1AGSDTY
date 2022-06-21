using UnityEngine;using UnityEngine.UI;public class pet1_lovebar:MonoBehaviour{
    public lovexp lovexp;
    public Image fillImage;
    Slider slider;
    void Start(){
        lovexp.currentLove=0;
        lovexp.maxLove=200; slider=GetComponent<Slider>();
    }
    void Update(){
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=lovexp.currentLove/lovexp.maxLove;
        slider.value=fillValue;
    }
}