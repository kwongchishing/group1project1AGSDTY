using UnityEngine;public class sisterHealth:MonoBehaviour{
    public wAXE_health wAXE_health;
    Animator anim;
    float bullhitcount,bigfoxhitcount;
    void Start(){
        anim=GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider monster1){
        if(monster1.gameObject.tag=="bull_weapon"){
            wAXE_health.currentHealth=wAXE_health.currentHealth-3f/wAXE_health.playerDefense;
            bullhitcount++;
            if(bullhitcount>=4){
                anim.SetTrigger("hurt");
                bullhitcount=0;
            }
        }
        if(monster1.gameObject.tag=="bull_heavyweapon"){
            wAXE_health.currentHealth=wAXE_health.currentHealth-15f/wAXE_health.playerDefense;
            bullhitcount++;
            if(bullhitcount>=1){
                anim.SetTrigger("hurt");
                bullhitcount=0;
            }
        }
        if(monster1.gameObject.tag=="bigfox"){
            wAXE_health.currentHealth=wAXE_health.currentHealth-5f/wAXE_health.playerDefense;
            bigfoxhitcount+=0.4f;
            if(bigfoxhitcount >= 1.8f){
                anim.SetTrigger("hurt");
                bigfoxhitcount=0;
            }
        }
    }    
}