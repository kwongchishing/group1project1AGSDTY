using UnityEngine;public class lookatplayer2:MonoBehaviour{
    GameObject Player;
    public GameObject Player2;
    float distancep1, distancep2;
    public Transform p1,p2;
    public save2 save2;
    void Update(){
        distancep1=Vector3.Distance(p1.transform.position,transform.position);
        distancep2=Vector3.Distance(p2.transform.position,transform.position);
        Player =GameObject.FindWithTag("Player");
        if(save2.finishgame<1){
            transform.LookAt(Player.transform);
        }
        if(distancep1<distancep2&&save2.finishgame>0){
            transform.LookAt(Player.transform);
        }
        else if(distancep1>distancep2&&save2.finishgame>0){
            transform.LookAt(Player2.transform);
        }
    }
}