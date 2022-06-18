using UnityEngine;public class chatwithSport:MonoBehaviour{
    public GameObject Text0,Player;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            Text0.SetActive(true);}
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            Text0.SetActive(false);
        }}}