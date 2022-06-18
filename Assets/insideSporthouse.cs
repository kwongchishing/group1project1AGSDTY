using UnityEngine;public class insideSporthouse:MonoBehaviour{
    public GameObject enterHouse;
    public correctCount cc;
    public Save save;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save.finishMaths>0&&cc.retryOrnot>0){
            enterHouse.SetActive(true);
        }
    }
        void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            enterHouse.SetActive(false);
        }
    }
}