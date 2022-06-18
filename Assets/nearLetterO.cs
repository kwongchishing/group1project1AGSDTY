using UnityEngine;public class nearLetterO:MonoBehaviour{
    public GameObject pickLetterOstonetext;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player") pickLetterOstonetext.SetActive(true);
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player") pickLetterOstonetext.SetActive(false);
    }
}