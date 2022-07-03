using UnityEngine;public class investfunction:MonoBehaviour{
    public save2 save2;
    public float npctotal,npcget,count;    
    public void invest(){
        npcget=(float)save2.currentMoney;
        save2.currentMoney=0;
        npctotal+=npcget;
        npcget=0;
    }
    public void withdraw(){
        save2.currentMoney=(int)npctotal;
        npctotal=0;
        count=0;
    }
    void Update(){
        if(npctotal>0){
            count+=1f*Time.deltaTime;
            if(count>=50){
                npctotal*=1.03f;
                count=0;
            }
        }
    }
}