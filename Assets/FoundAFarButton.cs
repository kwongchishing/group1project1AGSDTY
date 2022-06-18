using UnityEngine;using UnityEngine.UI;public class FoundAFarButton:MonoBehaviour{
    public GameObject AfarButtonText;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            AfarButtonText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            AfarButtonText.SetActive(false);
        }
    }
}