using UnityEngine;public class checkcageIsbroken:MonoBehaviour{
    public save2 save2;
    public GameObject collectKeyText;
    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save2.cageIsdestroy>0){collectKeyText.SetActive(true);}
    }
    public void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"&&save2.cageIsdestroy>0){collectKeyText.SetActive(true);}
    }
    public void OnTriggerExit(Collider other){
        if (other.gameObject.tag=="Player"&&save2.cageIsdestroy>0){collectKeyText.SetActive(false);}
    }}