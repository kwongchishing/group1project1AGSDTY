using System.Collections;using System.Collections.Generic;using UnityEngine;public class activeSaveNPCcomesavePlayer:MonoBehaviour{
    public GameObject SaveNpchelp;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="Player"){
            SaveNpchelp.SetActive(true);
        }
    }}