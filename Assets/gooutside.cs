using UnityEngine;public class gooutside:MonoBehaviour{
    public GameObject leaveHouse,leaveHouseAXE;
    public Save save;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE<1){
            leaveHouse.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            leaveHouseAXE.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE<1){
            leaveHouse.SetActive(false);
        }
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            leaveHouseAXE.SetActive(false);
        }
    }
}