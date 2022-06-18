using UnityEngine;public class Ostonehousecollider:MonoBehaviour{
    public GameObject goinOstonehouseText;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            goinOstonehouseText.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            goinOstonehouseText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="Player"){
            goinOstonehouseText.SetActive(false);
        }
    }   
}