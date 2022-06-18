using UnityEngine;public class myhouse:MonoBehaviour{
    public GameObject enterMyHouse;    
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            enterMyHouse.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            enterMyHouse.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            enterMyHouse.SetActive(false);
        }
    }
}