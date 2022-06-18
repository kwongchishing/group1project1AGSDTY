using UnityEngine;public class AXE_text:MonoBehaviour{
    public Save save;
    public GameObject axe_pressenter;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save.angryloginhousedie>0){
            axe_pressenter.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"&&save.angryloginhousedie>0){
            axe_pressenter.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"&&save.angryloginhousedie>0){
            axe_pressenter.SetActive(false);
        }
    }
}