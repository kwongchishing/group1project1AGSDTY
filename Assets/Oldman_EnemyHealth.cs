using UnityEngine;public class Oldman_EnemyHealth:MonoBehaviour{
    public AudioSource gethit,weaponhit,oldmanattack1Sound;
    public float currentHealth,maxHealth;
    public GameObject player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisOldman,HealthBar,WeaponrightLeg,Arrow;
    Animator anim;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public int dropmoney, hitbyPlayercount;
    public save2 save2;
    public OldmanEnemy_Pathfinding OldmanEnemy_Pathfinding;
    void Start(){
        anim=thisOldman.GetComponent<Animator>();
        currentHealth=1000f;
        maxHealth=1000f;
        dropmoney=Random.Range(20,31);
    }
    void Update(){
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            gethit.Play(); weaponhit.Play(); Vector3 difference = (thisOldman.transform.position - player.transform.position) / 559;
            thisOldman.transform.position = new Vector3(thisOldman.transform.position.x + difference.x, thisOldman.transform.position.y, thisOldman.transform.position.z + difference.z);
            if (hitbyPlayercount>12){anim.ResetTrigger("kickattack"); oldmanattack1Sound.Stop(); anim.SetTrigger("gethit"); hitbyPlayercount=0;}
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethit.Play(); weaponhit.Play();
            hitbyPlayercount++; Vector3 difference = (thisOldman.transform.position - player.transform.position) / 559;
            thisOldman.transform.position = new Vector3(thisOldman.transform.position.x + difference.x, thisOldman.transform.position.y, thisOldman.transform.position.z + difference.z);
            if (hitbyPlayercount>12){anim.ResetTrigger("kickattack"); oldmanattack1Sound.Stop(); anim.SetTrigger("gethit"); hitbyPlayercount=0;}
        }
        if(currentHealth<=0){
            oldmanattack1Sound.Stop(); WeaponrightLeg.GetComponent<BoxCollider>().enabled=false;//AttackPlayerCol
            Destroy(HealthBar); Destroy(Arrow); trig=false;
            this.gameObject.GetComponent<CapsuleCollider>().enabled=false;//hitbyplayerCol
            anim.SetTrigger("die");
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f; Vector3 difference = (thisOldman.transform.position - player.transform.position) / 9;
            thisOldman.transform.position = new Vector3(thisOldman.transform.position.x + difference.x, thisOldman.transform.position.y, thisOldman.transform.position.z + difference.z); anim.SetTrigger("gethit");
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*197f;
            gethit.Play();
            anim.SetTrigger("gethit");
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*197f*Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}