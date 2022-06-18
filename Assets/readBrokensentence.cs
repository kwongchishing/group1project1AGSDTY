using UnityEngine;public class readBrokensentence:MonoBehaviour{
    public GameObject readBrokenword;
    public save2 save2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save2.finishsentence<1){
            readBrokenword.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            readBrokenword.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            readBrokenword.SetActive(false);
        }
    }
}