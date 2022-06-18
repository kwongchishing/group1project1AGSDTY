using UnityEngine;public class lookatplayer3common:MonoBehaviour{
    public GameObject Player1,Player2;
    float distancep1,distancep2;
    public Transform p1,p2;
    void Update(){
        distancep1=Vector3.Distance(p1.transform.position,transform.position);
        distancep2=Vector3.Distance(p2.transform.position,transform.position);
        if(distancep1<distancep2){
            transform.LookAt(new Vector3(Player1.transform.position.x,transform.position.y,Player1.transform.position.z));
        }
        else{
            transform.LookAt(new Vector3(Player2.transform.position.x,transform.position.y,Player2.transform.position.z));
        }
    }
}