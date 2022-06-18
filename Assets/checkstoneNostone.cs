using UnityEngine;public class checkstoneNostone:MonoBehaviour{
    public GameObject checkOstone,noOstone;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="Player"){
            checkOstone.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag=="Player"){
            checkOstone.SetActive(false);
            noOstone.SetActive(false);
        }
    }
}