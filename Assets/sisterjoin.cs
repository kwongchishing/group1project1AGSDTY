using UnityEngine;public class sisterjoin:MonoBehaviour{
    public GameObject presstojoin,Player;
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<=1.5f){
            presstojoin.SetActive(true);}
        else{presstojoin.SetActive(false);}
    }
}