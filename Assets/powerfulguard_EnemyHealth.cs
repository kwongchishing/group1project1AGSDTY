using UnityEngine;using UnityEngine.AI;public class powerfulguard_EnemyHealth:MonoBehaviour{
    public AudioSource gethit,weaponhit;
    public float currentHealth,maxHealth;
    public GameObject player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisGuard,HealthBar,Weapon,Weaponheavy;
    Animator anim;
    int hitbyPlayercount;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public int dropmoney;
    public save2 save2;
    public powerfulGuard_Pathfinding guard_Pathfinding;
    void Start(){
        anim=thisGuard.GetComponent<Animator>();
        currentHealth=1000f;
        maxHealth=1000f;
        dropmoney=Random.Range(10,26);
    }
    void Update(){
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            hitbyPlayercount++;
            gethit.Play(); weaponhit.Play(); Vector3 difference = (thisGuard.transform.position - player.transform.position) / 507;
            thisGuard.transform.position = new Vector3(thisGuard.transform.position.x + difference.x, thisGuard.transform.position.y, thisGuard.transform.position.z + difference.z);
            if (hitbyPlayercount>19){anim.SetTrigger("gethit"); hitbyPlayercount=0;}
        }
        if(trig && checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethit.Play(); weaponhit.Play();
            hitbyPlayercount++; Vector3 difference = (thisGuard.transform.position - player.transform.position) / 507;
            thisGuard.transform.position = new Vector3(thisGuard.transform.position.x + difference.x, thisGuard.transform.position.y, thisGuard.transform.position.z + difference.z);
            if (hitbyPlayercount>19){anim.SetTrigger("gethit"); hitbyPlayercount=0;}
        }
        if(currentHealth<=0){
            Weapon.GetComponent<BoxCollider>().enabled=false; Weaponheavy.GetComponent<BoxCollider>().enabled=false;
            Destroy(HealthBar); guard_Pathfinding.attackmode=6; trig=false;
            thisGuard.GetComponent<NavMeshAgent>().enabled=false;
            this.gameObject.GetComponent<BoxCollider>().enabled=false;
            guard_Pathfinding.powerfulguardattackcloseCol(); guard_Pathfinding.powerfulguardheavyattackcloseCol();
            anim.SetTrigger("die");
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f; Vector3 difference = (thisGuard.transform.position - player.transform.position) / 3;
            thisGuard.transform.position = new Vector3(thisGuard.transform.position.x + difference.x, thisGuard.transform.position.y, thisGuard.transform.position.z + difference.z);
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*192f;
            gethit.Play();
            anim.SetTrigger("gethit");
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*192f*Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}