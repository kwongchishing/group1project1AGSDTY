using UnityEngine;public class exitUGtext:MonoBehaviour{
    public GameObject exitUGText;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="Player"){
            exitUGText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag=="Player"){
            exitUGText.SetActive(false);
        }
    }
}