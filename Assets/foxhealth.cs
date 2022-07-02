using UnityEngine;using UnityEngine.AI;public class foxhealth:MonoBehaviour{
    public AudioSource chanweaponhit,punch2, punch, gethit, weaponhit;
    public float currentHealth, maxHealth;
    public GameObject sisterhitlight, sisterhitspark,sblood1FX, sblood2FX, sblood3FX, chanblood1FX,chanblood2FX,chanblood3FX,fox_hpbarFunction,sisterhitFX3,sisterhitFX4,sisterhitFX1,sisterhitFX2,player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisBull,HealthBar;
    Animator anim;
    public Transform tower;
    public tower1health tower1health;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public int dropmoney;
    void Start(){
        anim=thisBull.GetComponent<Animator>();
        currentHealth=700f;
        maxHealth=700f;
        dropmoney=Random.Range(10,31);
    }
    void Update(){
        if(trig&&checklight.lighting&&currentHealth>0){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            gethit.Play(); weaponhit.Play();
        }
        if(trig&&checklight.heavying&&currentHealth>0){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.2f;
            gethit.Play(); weaponhit.Play();
        }
        if(Vector3.Distance(transform.position,tower.transform.position)<3.5f&&currentHealth>0){
            tower1health.currentHealth-=8*Time.deltaTime;
            tower1health.hitbymonstercount+=1*Time.deltaTime;
        }
        if(Vector3.Distance(transform.position,tower.transform.position)>10f){
            GetComponent<SkinnedMeshRenderer>().enabled=false; fox_hpbarFunction.SetActive(false);
        }
        if(Vector3.Distance(transform.position,tower.transform.position)<=10f){
            GetComponent<SkinnedMeshRenderer>().enabled=true; fox_hpbarFunction.SetActive(true);
        }
        if (currentHealth<=0){
            anim.SetBool("attack", false); anim.SetTrigger("die");Destroy(HealthBar);GetComponent<BoxCollider>().enabled = false;
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if (other.gameObject.tag == "sisterweapon")
        {
            currentHealth = currentHealth - exp.playerAttack;
            gethit.Play(); weaponhit.Play();
            sisterhitlight.GetComponent<ParticleSystem>().Play();
            sisterhitspark.GetComponent<ParticleSystem>().Play();
            sblood1FX.GetComponent<ParticleSystem>().Play();
            sblood2FX.GetComponent<ParticleSystem>().Play();
            sblood3FX.GetComponent<ParticleSystem>().Play();
        }
        if(other.gameObject.tag == "sisterheavyweapon")
        {
            currentHealth=currentHealth-exp.playerAttack*10;
            gethit.Play(); weaponhit.Play();
            sisterhitlight.GetComponent<ParticleSystem>().Play();
            sisterhitspark.GetComponent<ParticleSystem>().Play();
            sblood1FX.GetComponent<ParticleSystem>().Play();
            sblood2FX.GetComponent<ParticleSystem>().Play();
            sblood3FX.GetComponent<ParticleSystem>().Play();
        }
        if (other.gameObject.tag == "chan")
        {
            currentHealth = currentHealth-=10;chanweaponhit.Play(); gethit.Play();
            chanblood1FX.GetComponent<ParticleSystem>().Play();
            chanblood2FX.GetComponent<ParticleSystem>().Play();
            chanblood3FX.GetComponent<ParticleSystem>().Play();
        }
        if (other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f;
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f; gethit.Play();
        }
        if(other.gameObject.tag=="p2lightattack"){
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            punch.Play();
            sisterhitFX1.GetComponent<ParticleSystem>().Play();
            sisterhitFX2.GetComponent<ParticleSystem>().Play(); gethit.Play();
        }
        if(other.gameObject.tag=="p2heavyattack"){
            currentHealth=currentHealth-exp.playerAttack*2.9f;
            punch2.Play();
            sisterhitFX3.GetComponent<ParticleSystem>().Play();
            sisterhitFX4.GetComponent<ParticleSystem>().Play(); gethit.Play();
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f*Time.deltaTime;
        }
        if (other.gameObject.tag == "sisterweapon")
        {
            currentHealth = currentHealth - exp.playerAttack;
        }
        if (other.gameObject.tag == "sisterheavyweapon")
        {
            currentHealth = currentHealth - exp.playerAttack * 10;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}