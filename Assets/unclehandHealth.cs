using UnityEngine;using UnityEngine.UI;public class unclehandHealth:MonoBehaviour{
    public uncleenemyHealth unclehandhealth;
    public Image fillImage;
    Slider slider;
    void Start(){
        unclehandhealth.currentHealth=220;
        unclehandhealth.maxHealth=220;slider=GetComponent<Slider>();        
    }
    void Update(){
        if(slider.value<=slider.minValue){
            fillImage.enabled=false;
        }
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=unclehandhealth.currentHealth/unclehandhealth.maxHealth;
        slider.value=fillValue;
    }
}