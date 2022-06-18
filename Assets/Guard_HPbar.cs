using UnityEngine;using UnityEngine.UI;public class Guard_HPbar:MonoBehaviour{
    public guard_EnemyHealth boyhealth;
    public Image fillImage;
    private Slider slider;
    void Start(){
        boyhealth.currentHealth=700;
        boyhealth.maxHealth=700; slider =GetComponent<Slider>();
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