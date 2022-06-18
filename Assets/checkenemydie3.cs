using UnityEngine;public class checkenemydie3:MonoBehaviour{
    public GameObject thisenemy;
    public save2 save2;
    void Start(){
        if(save2.bull_kingisdead3>0){
            Destroy(thisenemy);
            Destroy(this.gameObject);
        }
    }
    void Update(){
        if(thisenemy==null){
            save2.bull_kingisdead3++;
            Destroy(this.gameObject);
        }
    }
}