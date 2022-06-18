using System.Collections;using System.Collections.Generic;using UnityEngine;public class pickuppotion:MonoBehaviour{
    public GameObject canpicktext;
    void OnTriggerEnter(Collider other){
        if(other.transform.tag=="Player") canpicktext.SetActive(true);
    }
    void OnTriggerExit(Collider other){
        if(other.transform.tag=="Player") canpicktext.SetActive(false);
    }
}