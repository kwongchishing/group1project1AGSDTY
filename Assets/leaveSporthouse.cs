using UnityEngine;public class leaveSporthouse:MonoBehaviour{
    public GameObject leaveHouse;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){leaveHouse.SetActive(true);}}
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){leaveHouse.SetActive(false);}}}