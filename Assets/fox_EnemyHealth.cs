using UnityEngine;using UnityEngine.AI;public class fox_EnemyHealth:MonoBehaviour{
    public AudioSource punch2,punch,gethit,weaponhit;
    public float currentHealth,maxHealth;
    public GameObject sister, sisterhitlight, sisterhitspark, sblood1FX, sblood2FX, sblood3FX,sisterhitFX3, sisterhitFX4,sisterhitFX1,sisterhitFX2,player,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX,thisBull,HealthBar;
    Animator anim;
    public WAXE_exp exp;
    bool trig;
    public AXE_lighting checklight;
    public int dropmoney,hitbyPlayercount;
    public save2 save2;
    public fox_pathfinding bull_Enemypathfinding;
    void Start(){
        anim=thisBull.GetComponent<Animator>();
        currentHealth=10000f;
        maxHealth=10000f;
        dropmoney=Random.Range(30,51);
    }
    void Update(){
        if(trig && checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth=currentHealth-exp.playerAttack;
            hitbyPlayercount++;
            gethit.Play(); weaponhit.Play(); Vector3 difference = (thisBull.transform.position - player.transform.position) / 550;
            thisBull.transform.position = new Vector3(thisBull.transform.position.x + difference.x, thisBull.transform.position.y, thisBull.transform.position.z + difference.z);
        }
        if (trig && checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            currentHealth = currentHealth - exp.playerAttack * 1.2f;
            gethit.Play(); weaponhit.Play();
            hitbyPlayercount++; Vector3 difference = (thisBull.transform.position - player.transform.position) / 550;
            thisBull.transform.position = new Vector3(thisBull.transform.position.x + difference.x, thisBull.transform.position.y, thisBull.transform.position.z + difference.z);
        }
        if (currentHealth <= 0){
            bull_Enemypathfinding.attackcloseCol(); Destroy(HealthBar); bull_Enemypathfinding.attackmode = 6; trig = false;
            thisBull.GetComponent<NavMeshAgent>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            anim.SetTrigger("die");
        }
        if (hitbyPlayercount > 300) { anim.SetTrigger("gethit"); hitbyPlayercount = 0; }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AXE")
        {
            trig = true;
        }
        if (other.gameObject.tag == "combo3storm")
        {
            currentHealth = currentHealth - exp.playerAttack * 12f; Vector3 difference = (thisBull.transform.position - player.transform.position) / 2.6f;
            thisBull.transform.position = new Vector3(thisBull.transform.position.x + difference.x, thisBull.transform.position.y, thisBull.transform.position.z + difference.z);
        }
        if (other.gameObject.tag == "electricskill")
        {
            currentHealth = currentHealth - exp.playerAttack * 282f;
            gethit.Play();
            anim.SetTrigger("gethit");
        }
        if (other.gameObject.tag == "sisterweapon")
        {
            currentHealth = currentHealth - 10 - save2.sisterextraattack;
            hitbyPlayercount++;
            gethit.Play(); weaponhit.Play();
            sisterhitlight.GetComponent<ParticleSystem>().Play();
            sisterhitspark.GetComponent<ParticleSystem>().Play();
            sblood1FX.GetComponent<ParticleSystem>().Play();
            sblood2FX.GetComponent<ParticleSystem>().Play();
            sblood3FX.GetComponent<ParticleSystem>().Play();
            Vector3 difference2 = (thisBull.transform.position - sister.transform.position) / 17;
            thisBull.transform.position = new Vector3(thisBull.transform.position.x + difference2.x, thisBull.transform.position.y, thisBull.transform.position.z + difference2.z);
        }
        if (other.gameObject.tag == "sisterheavyweapon")
        {
            currentHealth = currentHealth - 30 - save2.sisterextraattack;
            hitbyPlayercount++;
            gethit.Play(); weaponhit.Play();
            sisterhitlight.GetComponent<ParticleSystem>().Play();
            sisterhitspark.GetComponent<ParticleSystem>().Play();
            sblood1FX.GetComponent<ParticleSystem>().Play();
            sblood2FX.GetComponent<ParticleSystem>().Play();
            sblood3FX.GetComponent<ParticleSystem>().Play();
            Vector3 difference2 = (thisBull.transform.position - sister.transform.position) /9;
            thisBull.transform.position = new Vector3(thisBull.transform.position.x + difference2.x, thisBull.transform.position.y, thisBull.transform.position.z + difference2.z);
        }
        if (other.gameObject.tag == "p2lightattack")
        {
            currentHealth = currentHealth - exp.playerAttack * 1.9f;
            hitbyPlayercount++;
            punch.Play();
            sisterhitFX1.GetComponent<ParticleSystem>().Play();
            sisterhitFX2.GetComponent<ParticleSystem>().Play();
        }
        if (other.gameObject.tag == "p2heavyattack")
        {
            currentHealth = currentHealth - exp.playerAttack * 2.9f;
            hitbyPlayercount++;
            punch2.Play();
            sisterhitFX3.GetComponent<ParticleSystem>().Play();
            sisterhitFX4.GetComponent<ParticleSystem>().Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "electricskill")
        {
            currentHealth = currentHealth - exp.playerAttack * 482f * Time.deltaTime;
        }
        if (other.gameObject.tag == "sisterweapon")
        {
            currentHealth = currentHealth - 10 - save2.sisterextraattack;
        }
        if (other.gameObject.tag == "sisterheavyweapon")
        {
            currentHealth = currentHealth - 30 - save2.sisterextraattack;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "AXE")
        {
            trig = false;
        }
    }
}