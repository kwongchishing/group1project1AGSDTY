using UnityEngine;public class distancecheck:MonoBehaviour{
    public Transform Player,Player2;
    public GameObject findgirltext;   
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<=20||Vector3.Distance(Player2.transform.position,transform.position)<=20){
            findgirltext.SetActive(true);
            Destroy(this.gameObject,6);
        }
    }
}