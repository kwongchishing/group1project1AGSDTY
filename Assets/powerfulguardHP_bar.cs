using UnityEngine;using UnityEngine.UI;public class powerfulguardHP_bar:MonoBehaviour{
    public powerfulguard_EnemyHealth boyhealth;
    public Image fillImage;
    private Slider slider;
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