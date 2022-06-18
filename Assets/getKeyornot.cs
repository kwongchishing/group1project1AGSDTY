using UnityEngine;public class getKeyornot:MonoBehaviour{
    public GameObject nokeyText,pressentertoopenTEXT;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            pressentertoopenTEXT.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            pressentertoopenTEXT.SetActive(false);
            nokeyText.SetActive(false);
        }
    }
}