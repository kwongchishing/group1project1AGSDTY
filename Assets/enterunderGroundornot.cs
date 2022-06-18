using UnityEngine;public class enterunderGroundornot:MonoBehaviour{
    public GameObject enterornotText;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            enterornotText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            enterornotText.SetActive(false);
        }
    }
}