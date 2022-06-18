using UnityEngine;using UnityEngine.UI;public class Turtle_HPbar:MonoBehaviour{
    public Turtle_EnemyHealth boyhealth;
    public Image fillImage;
    Slider slider;
    void Start(){
        boyhealth.currentHealth=600;
        boyhealth.maxHealth=600; slider=GetComponent<Slider>();
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