using UnityEngine;public class finishfindgirltalkmother:MonoBehaviour{
    public Transform Player1,Player2;
    public save2 save2;
    public GameObject mothertalk;
    void Update(){
        if(Vector3.Distance(Player1.transform.position,transform.position)<=4f&&save2.findgirlMfinish>0||Vector3.Distance(Player2.transform.position,transform.position)<=4f&&save2.findgirlMfinish>0){
            mothertalk.SetActive(true);
        }
        else{
            mothertalk.SetActive(false);
        }
    }
}
