using UnityEngine;using UnityEngine.UI;public class boyWithWeaponhealthBar:MonoBehaviour{
    public boyWithWeaponHealth boyhealth;
    public Image fillImage;
    private Slider slider;
    void Start(){
        boyhealth.currentHealth=220;
        boyhealth.maxHealth=220;slider=GetComponent<Slider>();        
    }
    void Update(){
        if(slider.value<=slider.minValue){
            fillImage.enabled=false;}
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;}
        float fillValue=boyhealth.currentHealth/boyhealth.maxHealth;
        slider.value=fillValue;}
}