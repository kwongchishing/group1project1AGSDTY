using UnityEngine;using UnityEngine.UI;public class Oldman_HPbar:MonoBehaviour{
    public Oldman_EnemyHealth boyhealth;
    public Image fillImage;
    Slider slider;
    void Start(){
        boyhealth.currentHealth=1000;
        boyhealth.maxHealth=1000; slider=GetComponent<Slider>();
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