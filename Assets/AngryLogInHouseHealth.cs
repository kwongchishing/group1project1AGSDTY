using UnityEngine;public class AngryLogInHouseHealth:MonoBehaviour{
    public float currentHealth=6f;
    public float maxHealth=6f;
    public GameObject AngryLog,LFX1,LFX2,RFX1,RFX2,player;
    public Exp exp;
    public AudioSource punch1,die,punch2;
    public Save save;
    public save2 save2;
    public int dropmoney;
    Animator anim;
    void Start(){
        anim=AngryLog.GetComponent<Animator>();
        dropmoney=Random.Range(1,3);    }
    void Update(){
        if(currentHealth<=0){
            die.Play();
            exp.currentExp+=60;
            //ADD ONLY THIS LOG
            save.angryloginhousedie+= 1;//            
            save2.currentMoney+=dropmoney;save2.goodbadcount--;            
            Destroy(AngryLog);        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="PlayerHandLightAttack"){
            currentHealth=currentHealth-exp.playerAttack;
            RFX1.GetComponent<ParticleSystem>().Play();
            RFX2.GetComponent<ParticleSystem>().Play();
            punch1.Play();            
            Vector3 difference=(AngryLog.transform.position-player.transform.position)/1.5f;
            AngryLog.transform.position=new Vector3(AngryLog.transform.position.x+difference.x,AngryLog.transform.position.y,AngryLog.transform.position.z+difference.z);
            anim.SetTrigger("IsGetHit");
        }
        if(other.gameObject.tag=="PlayerHandHeavyAttack"){
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            LFX1.GetComponent<ParticleSystem>().Play();
            LFX2.GetComponent<ParticleSystem>().Play();
            punch2.Play();            
            Vector3 difference= (AngryLog.transform.position - player.transform.position) / 1.5f;
            AngryLog.transform.position=new Vector3(AngryLog.transform.position.x+difference.x,AngryLog.transform.position.y,AngryLog.transform.position.z+difference.z);
            anim.SetTrigger("IsGetHit");
        }
    }
}