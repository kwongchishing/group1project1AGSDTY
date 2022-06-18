using UnityEngine;using UnityEngine.UI;public class finalboss_HPbar:MonoBehaviour{
    public finalboss_EnemyHealth boyhealth;
    public Image fillImage;
    private Slider slider;
    void Start(){
        boyhealth.currentHealth=3000;
        boyhealth.maxHealth=3000; slider=GetComponent<Slider>();
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