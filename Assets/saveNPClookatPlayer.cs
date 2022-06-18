using UnityEngine;public class saveNPClookatPlayer:MonoBehaviour{
    public GameObject saveOrnotsaveText;
    public Transform player;
    void Update(){
        transform.LookAt(player);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            saveOrnotsaveText.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            saveOrnotsaveText.SetActive(false);
        }
    }
}