using UnityEngine;using UnityEngine.UI;public class boss1healthbar:MonoBehaviour{
    public Boss1HP boss1HP;
    public Image fillImage;
    private Slider slider;
    void Start(){
        boss1HP.currentHealth=3500;
        boss1HP.maxHealth=3500;slider=GetComponent<Slider>();}
    void Update(){
        if(slider.value<=slider.minValue){
            fillImage.enabled=false;
        }
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=boss1HP.currentHealth/boss1HP.maxHealth;
        slider.value=fillValue;
    }
}