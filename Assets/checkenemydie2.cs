using UnityEngine;public class checkenemydie2:MonoBehaviour{
    public GameObject thisenemy;
    public save2 save2;
    void Start(){
        if(save2.bull_kingisdead2>0){
            Destroy(thisenemy);
            Destroy(this.gameObject);
        }
    }
    void Update(){
        if(thisenemy==null){
            save2.bull_kingisdead2++;
            Destroy(this.gameObject);
        }
    }
}