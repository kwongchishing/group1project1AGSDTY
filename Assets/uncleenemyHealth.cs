using UnityEngine;public class uncleenemyHealth:MonoBehaviour{
    public AudioSource die,gethit,gethitheavy,weaponhit;
    public float currentHealth,maxHealth,hitbyplayercount;
    public GameObject thisUNCLE,player, hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX;
    Animator anim;
    public WAXE_exp exp;
    public bool trig;
    public AXE_lighting checklight;
    public int dropmoney;
    public save2 save2;
    void Start(){
        anim=thisUNCLE.GetComponent<Animator>();
        currentHealth=210f;
    maxHealth=210f;
        dropmoney=Random.Range(0,4);
    }
    void Update(){
        if(hitbyplayercount>5){
            anim.SetTrigger("gethit");
            hitbyplayercount=0;
        }
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
             gethit.Play(); weaponhit.Play();hitbyplayercount++;
            Vector3 difference = (thisUNCLE.transform.position - player.transform.position) / 500;
            thisUNCLE.transform.position = new Vector3(thisUNCLE.transform.position.x + difference.x, thisUNCLE.transform.position.y, thisUNCLE.transform.position.z + difference.z);
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethitheavy.Play(); weaponhit.Play(); hitbyplayercount++;
            Vector3 difference = (thisUNCLE.transform.position - player.transform.position) / 500;
            thisUNCLE.transform.position = new Vector3(thisUNCLE.transform.position.x + difference.x, thisUNCLE.transform.position.y, thisUNCLE.transform.position.z + difference.z);
        }
        if(currentHealth<=0){
            die.Play();            
            exp.currentExp+=62;
            Destroy(thisUNCLE);            
            save2.currentMoney=save2.currentMoney+dropmoney; save2.goodbadcount++;
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f;hitbyplayercount+=2; Vector3 difference = (thisUNCLE.transform.position - player.transform.position) /2.2f;
            thisUNCLE.transform.position = new Vector3(thisUNCLE.transform.position.x + difference.x, thisUNCLE.transform.position.y, thisUNCLE.transform.position.z + difference.z);
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f;hitbyplayercount+=3;
            gethitheavy.Play();
            anim.SetTrigger("gethit");
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f*Time.deltaTime;
            hitbyplayercount+=5*Time.deltaTime;
            gethitheavy.Play();
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}