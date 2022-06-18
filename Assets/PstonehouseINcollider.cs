using UnityEngine;public class PstonehouseINcollider:MonoBehaviour{
    public GameObject goinPstonehouseText;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            goinPstonehouseText.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            goinPstonehouseText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            goinPstonehouseText.SetActive(false);
        }
    }
}