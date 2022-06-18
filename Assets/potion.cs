using UnityEngine;public class potion:MonoBehaviour{
    public GameObject pickuptext;
    void OnTriggerEnter(Collider other){
        pickuptext.SetActive(true);
    }
    void OnTriggerExit(Collider other){
        pickuptext.SetActive(false);
    }
}