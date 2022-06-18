using UnityEngine;public class potionaskforshopping:MonoBehaviour{
    public GameObject asksisterforbuyText,askforbuyText,setting,Player;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            askforbuyText.SetActive(true);            
        }
        if(other.gameObject.tag=="Player2"){
            asksisterforbuyText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            askforbuyText.SetActive(false);
            setting.SetActive(true);
        }
        if(other.gameObject.tag=="Player2"){
            asksisterforbuyText.SetActive(false);
            setting.SetActive(true);
        }
    }
}