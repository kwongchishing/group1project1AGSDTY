using UnityEngine;public class gooutsidePotionhouse:MonoBehaviour{
    public GameObject leaveHouse,leaveHousesister;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            leaveHouse.SetActive(true);
        }
        if(other.gameObject.tag=="Player2"){
            leaveHousesister.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            leaveHouse.SetActive(false);
        }
        if(other.gameObject.tag=="Player2"){
            leaveHousesister.SetActive(false);
        }
    }
}