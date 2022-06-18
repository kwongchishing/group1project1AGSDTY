using UnityEngine;public class doorToCastleDistance:MonoBehaviour{
    public Transform Player;
    public GameObject insideCastleornot,doorislocked;
    public save2 save2;
    void Update(){
        if(Player==null) Player=GameObject.FindWithTag("Player").transform;
        if(Vector3.Distance(Player.transform.position,transform.position)<2.5f&&save2.finishsentence>0){
            insideCastleornot.SetActive(true);
        }
        else if(Vector3.Distance(Player.transform.position,transform.position)>2.5f&&save2.finishsentence>0){
            insideCastleornot.SetActive(false);
        }
        else if(Vector3.Distance(Player.transform.position,transform.position)>2.5f&&save2.finishsentence<1){
            doorislocked.SetActive(false);
        }
        else if(Vector3.Distance(Player.transform.position,transform.position)<2.5f&&save2.finishsentence<1){
            doorislocked.SetActive(true);
        }
    }
}