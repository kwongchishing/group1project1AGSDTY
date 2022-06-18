using UnityEngine;using UnityEngine.UI;public class AngryLogHealthBarCommon:MonoBehaviour{
    public AngryLoghealthcommon angryloghealth;
    public Image fillImage;
    private Slider slider;
    void Start(){
        angryloghealth.currentHealth=6;
        angryloghealth.maxHealth=6;slider=GetComponent<Slider>();}
    void Update(){
        if(slider.value<=slider.minValue){
            fillImage.enabled=false;
        }
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=angryloghealth.currentHealth/angryloghealth.maxHealth;
        slider.value=fillValue;
    }
}