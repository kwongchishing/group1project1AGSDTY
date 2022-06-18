using UnityEngine;using UnityEngine.UI;public class gethpdata:MonoBehaviour{
    public save2 save2;
    public Ischange Ischange;
    public Health Health;
    public Text thistext;
    public wAXE_health wAXE_health;
    void Update(){
        if(Ischange.ischange<1){thistext.text=Health.currentHealth.ToString();}
        else{thistext.text=wAXE_health.currentHealth.ToString();}
        if(save2.finishgame>0){
            thistext.text=wAXE_health.currentHealth.ToString();
        }
    }
}