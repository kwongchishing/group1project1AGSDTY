using UnityEngine;public class potionhouseenterText:MonoBehaviour{
    public GameObject enterpotionshoptextpink,enterpotionshoptext;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){enterpotionshoptext.SetActive(true);}
        if(other.gameObject.tag=="Player2"){enterpotionshoptextpink.SetActive(true);}
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){enterpotionshoptext.SetActive(true);}
        if(other.gameObject.tag=="Player2"){enterpotionshoptextpink.SetActive(true);}
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){enterpotionshoptext.SetActive(false);}
        if(other.gameObject.tag=="Player2"){enterpotionshoptextpink.SetActive(false);}
    }
}