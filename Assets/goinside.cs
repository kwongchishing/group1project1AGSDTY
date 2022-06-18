using UnityEngine;public class goinside:MonoBehaviour{
    public Save save;
    public save2 save2;
    public GameObject enterHouse,entercheckMATHNPCdie;
    public Ischange Ischange;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE<1&&Ischange.ischange<1){
            enterHouse.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            entercheckMATHNPCdie.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.w_AXE>0){
            entercheckMATHNPCdie.SetActive(true);
        }
    }
void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE<1&&Ischange.ischange<1){
            enterHouse.SetActive(false);
        }
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            entercheckMATHNPCdie.SetActive(false);
        }
        if(other.gameObject.tag=="Player"&&save2.w_AXE>0){
            entercheckMATHNPCdie.SetActive(false);
        }
    }
}