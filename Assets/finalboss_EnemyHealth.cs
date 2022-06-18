using UnityEngine;using UnityEngine.UI;using UnityEngine.AI;public class finalboss_EnemyHealth:MonoBehaviour{
    public AudioSource gethit,weaponhit,dragonhurt1,dragonhurt2,dragonhurt3;
    public float currentHealth,maxHealth;
    public GameObject player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisGuard,Weapon;
    Animator anim;
    public int dragonchangepositioncount,dropmoney,hitbyPlayercount;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public save2 save2;
    public finalboss_Pathfinding guard_Pathfinding;
    void Start(){
        anim=thisGuard.GetComponent<Animator>();
        currentHealth=3000f;
        maxHealth=3000f;
        dropmoney=Random.Range(100,121);}
    void Update(){        
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            hitbyPlayercount++;
            dragonchangepositioncount++;
            gethit.Play();
            weaponhit.Play();
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethit.Play();
            weaponhit.Play();
            hitbyPlayercount++;
            dragonchangepositioncount++;
        }
        if(hitbyPlayercount==8){
            dragonhurt2.Play();
        }
        if(hitbyPlayercount==19){
            dragonhurt3.Play();
        }
        if(hitbyPlayercount>39){
            anim.SetTrigger("gethit"); dragonhurt1.Play();
             hitbyPlayercount=0;}
        if(currentHealth<=0){
            Weapon.GetComponent<CapsuleCollider>().enabled=false;
            guard_Pathfinding.attackmode=6;
            trig=false;
            thisGuard.GetComponent<NavMeshAgent>().enabled=false;
            this.gameObject.GetComponent<CapsuleCollider>().enabled=false;
            guard_Pathfinding.guardattackcloseCol();
            guard_Pathfinding.magicattack2closeCol();
            guard_Pathfinding.magicattack3closeCol();
            guard_Pathfinding.magicattack4closeCol();
            guard_Pathfinding.magicattack5closeCol();
            guard_Pathfinding.magicattack6closeCol();
            anim.SetTrigger("die");}
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f;
            dragonchangepositioncount++;
            hitbyPlayercount+=3;
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*192f;
            dragonchangepositioncount+=10;
            hitbyPlayercount+=3;
        }
    }
    void OnTriggerStay(Collider other){
        if (other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*192f*Time.deltaTime;
            dragonchangepositioncount++;
            hitbyPlayercount++;
        }
    }
        void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}