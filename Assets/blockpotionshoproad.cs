using UnityEngine;public class blockpotionshoproad:MonoBehaviour{
    public save2 save2;
    void Update(){
        if(save2.isjoined==true){
            this.GetComponent<BoxCollider>().enabled=true;
        }
        else{
            this.GetComponent<BoxCollider>().enabled=false;
        }
    }
}