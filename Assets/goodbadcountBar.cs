using UnityEngine;using UnityEngine.UI;public class goodbadcountBar:MonoBehaviour{
    public save2 save2;
    Slider slider; 
    void Start(){slider=GetComponent<Slider>();} 
    void Update(){ 
        slider.value=save2.goodbadcount/100;} }