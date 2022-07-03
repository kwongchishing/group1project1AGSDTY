using UnityEngine;public class distanceshowinterest:MonoBehaviour{
    public GameObject Player,Player2,interesttext;
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<3f||Vector3.Distance(Player2.transform.position,transform.position)<3f){
            interesttext.SetActive(true);
        }
        else{
            interesttext.SetActive(false);
        }
    }
}