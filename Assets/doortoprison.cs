using UnityEngine;public class doortoprison:MonoBehaviour{
    public Transform Player;
    public GameObject insideprisonornot;
    void Update(){    
        if(Player==null) Player=GameObject.FindWithTag("Player").transform;
        if(Vector3.Distance(Player.transform.position,transform.position)<2.3f){
            insideprisonornot.SetActive(true);
        }
        else if(Vector3.Distance(Player.transform.position,transform.position)>2.3f){
            insideprisonornot.SetActive(false);
        }
    }
}