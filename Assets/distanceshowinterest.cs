using UnityEngine;public class distanceshowinterest:MonoBehaviour{
    public GameObject Player,Player2,interesttext;
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<5f||Vector3.Distance(Player2.transform.position,transform.position)<5f){
            interesttext.SetActive(true);
        }
        else{
            interesttext.SetActive(false);
        }
    }
}