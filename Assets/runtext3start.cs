using UnityEngine;public class runtext3start:MonoBehaviour{
    public GameObject runText3;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="Player"){
            runText3.SetActive(true);}}}