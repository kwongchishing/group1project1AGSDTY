using UnityEngine;using UnityEngine.UI;public class brokenaxedetector:MonoBehaviour{
    public Save save;
    public GameObject youshouldfirstgetaxe,wall,missiondetect1,youshouldfindnpcfixaxe;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            Destroy(missiondetect1);            
            if(save.getbrokenaxe<1){
                youshouldfirstgetaxe.SetActive(true);
            }
            if(save.getbrokenaxe>0){
                Destroy(wall);
                youshouldfindnpcfixaxe.SetActive(true);
            }}}
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            Destroy(missiondetect1);
            if(save.getbrokenaxe<1){
                youshouldfirstgetaxe.SetActive(true);
            }
            if(save.getbrokenaxe>0){
                Destroy(wall);
                youshouldfindnpcfixaxe.SetActive(true);
            }
        }}
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            youshouldfirstgetaxe.SetActive(false);
            youshouldfindnpcfixaxe.SetActive(false);}}}