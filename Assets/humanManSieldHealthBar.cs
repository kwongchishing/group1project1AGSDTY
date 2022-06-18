using UnityEngine;using UnityEngine.UI;public class humanManSieldHealthBar:MonoBehaviour{
    public humanShieldEnemyHP boyhealth;
    public Image fillImage;
    Slider slider;
    void Start(){
        boyhealth.currentHealth=390;
        boyhealth.maxHealth=390;slider =GetComponent<Slider>();
    }
    void Update(){
        if(slider.value<=slider.minValue){
            fillImage.enabled=false;
        }
        if(slider.value>slider.minValue&&!fillImage.enabled){
            fillImage.enabled=true;
        }
        float fillValue=boyhealth.currentHealth/boyhealth.maxHealth;
        slider.value=fillValue;
    }
}