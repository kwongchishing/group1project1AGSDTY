using UnityEngine;public class well2DistancePlayer:MonoBehaviour{
    public Transform Player;
    public GameObject insideWellornot;
    public save2 save2;
    void Update(){
        if(Player==null) Player=GameObject.FindWithTag("Player").transform;
        if(Vector3.Distance(Player.transform.position,transform.position)<3.7f&&save2.clearwell2>0){
            insideWellornot.SetActive(true);
        }
        else{
            insideWellornot.SetActive(false);
        }
    }
}