using UnityEngine;public class wellDistanceplayer:MonoBehaviour{
    public Transform Player;
    public GameObject insideWellornot;
    void Update(){
        if(Player==null) Player=GameObject.FindWithTag("Player").transform;
        if(Vector3.Distance(Player.transform.position,transform.position)<3.7f){
            insideWellornot.SetActive(true);
        }
        else{
            insideWellornot.SetActive(false);
        }
    }
}