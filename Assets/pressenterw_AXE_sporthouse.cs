using UnityEngine;public class pressenterw_AXE_sporthouse:MonoBehaviour{
    public GameObject w_AXEchecksportHouse;
    public Save save;
    public save2 save2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            w_AXEchecksportHouse.SetActive(true);}
        if(other.gameObject.tag=="Player"&&save2.w_AXE>0){
            w_AXEchecksportHouse.SetActive(true);}}
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"&&save.w_AXE>0){
            w_AXEchecksportHouse.SetActive(false);}
        if(other.gameObject.tag=="Player"&&save2.w_AXE>0){
            w_AXEchecksportHouse.SetActive(false);}}}