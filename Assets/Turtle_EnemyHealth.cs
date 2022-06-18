using UnityEngine;using UnityEngine.AI;public class Turtle_EnemyHealth:MonoBehaviour{
    public AudioSource gethit,weaponhit;
    public float currentHealth,maxHealth;
    public GameObject player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisTurtle,HealthBar,Weapon;
    Animator anim;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public int dropmoney,hitbyPlayercount;
    public save2 save2;
    public Turtle_Pathfinding Turtle_Pathfinding;
    void Start(){
        anim=thisTurtle.GetComponent<Animator>();
        currentHealth=600f;
        maxHealth=600f;
        dropmoney=Random.Range(8,21);
    }
    void Update(){
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            gethit.Play();weaponhit.Play();
            if(hitbyPlayercount>12){anim.SetTrigger("gethit");hitbyPlayercount=0;}
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethit.Play(); weaponhit.Play();
            hitbyPlayercount++;
            if(hitbyPlayercount>12){anim.SetTrigger("gethit");hitbyPlayercount=0;}
        }
        if(currentHealth<=0){
            Weapon.GetComponent<BoxCollider>().enabled=false;//AttackPlayerCol
            Destroy(HealthBar);Turtle_Pathfinding.attackmode=6;trig=false;
            thisTurtle.GetComponent<NavMeshAgent>().enabled=false;
            this.gameObject.GetComponent<SphereCollider>().enabled=false;//hitbyplayerCol
            Turtle_Pathfinding.turtleattackcloseCol();
            anim.SetTrigger("die");
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f;
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f;
            gethit.Play();
            anim.SetTrigger("gethit");
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f*Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}