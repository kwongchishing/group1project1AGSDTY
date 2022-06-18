using UnityEngine;public class Mathnpclookatplayer:MonoBehaviour{    
    public GameObject mathselearnOrnot;
    public Transform player;
    void Update(){
        transform.LookAt(player);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            mathselearnOrnot.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            mathselearnOrnot.SetActive(false);
        }
    }
}