using UnityEngine;public class humanShieldEnemyHP:MonoBehaviour{
    public AudioSource die,gethit,weaponhitsound;
    public float currentHealth,maxHealth,hitbyplayercount;
    public GameObject player;
    Animator anim;
    public WAXE_exp exp;
    public bool trig;
    public AXE_lighting checklight;
    public GameObject thisboy,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX;
    public int dropmoney;
    public save2 save2;
    public void Start(){
        anim= thisboy.GetComponent<Animator>();
        currentHealth=390f;
        maxHealth=390f;
        dropmoney=Random.Range(0,6);}
    void Update(){
        if (hitbyplayercount > 20)
        {
            anim.SetTrigger("IsGetHit");
            hitbyplayercount = 0;
        }
        if (trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth =currentHealth-exp.playerAttack;
            gethit.Play(); weaponhitsound.Play(); hitbyplayercount+=0.2f; Vector3 difference = (thisboy.transform.position - player.transform.position) / 500;
            thisboy.transform.position = new Vector3(thisboy.transform.position.x + difference.x, thisboy.transform.position.y, thisboy.transform.position.z + difference.z);
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            gethit.Play(); weaponhitsound.Play(); hitbyplayercount+=0.2f; Vector3 difference = (thisboy.transform.position - player.transform.position) / 500;
            thisboy.transform.position = new Vector3(thisboy.transform.position.x + difference.x, thisboy.transform.position.y, thisboy.transform.position.z + difference.z);
        }
        if(currentHealth<=0){
            die.Play();
            exp.currentExp+=62;
            Destroy(thisboy);
            save2.currentMoney+=dropmoney;save2.goodbadcount++;
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth = currentHealth - exp.playerAttack*12f; hitbyplayercount+=2; Vector3 difference = (thisboy.transform.position - player.transform.position) / 2.6f;
            thisboy.transform.position = new Vector3(thisboy.transform.position.x + difference.x, thisboy.transform.position.y, thisboy.transform.position.z + difference.z);
        }
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f; hitbyplayercount += 3;
            gethit.Play();
            anim.SetTrigger("IsGetHit");
        }
    }
    void OnTriggerStay(Collider other){        
        if(other.gameObject.tag=="electricskill"){
            currentHealth=currentHealth-exp.playerAttack*82f*Time.deltaTime;
            hitbyplayercount += 5 * Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}