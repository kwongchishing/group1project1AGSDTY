using UnityEngine;public class AngryLogHealth:MonoBehaviour{
    public float currentHealth=6f;
    public float maxHealth=6f;
    //create other Angry delete
    public AudioSource getbrokenaxesound;
    public Save save;//
    public save2 save2;
    public GameObject getbrokenaxe,player,thisAngry,AngryLog,LFX1,LFX2,RFX1,RFX2;
    public AudioSource punch1,punch2,die;
    Animator anim;
    public Exp exp;
    public int dropmoney;
    void Start(){
        anim=thisAngry.GetComponent<Animator>();
        dropmoney=Random.Range(1,3);
    }
    //create other Angry delete
    void Update(){
        if(currentHealth<=0){
            die.Play();
            //create other Angry delete
            getbrokenaxe.SetActive(true);
            getbrokenaxesound.Play();
            save.getbrokenaxe+=1;//
            exp.currentExp+=60;
            save2.currentMoney+=dropmoney; save2.goodbadcount--;            
            Destroy(AngryLog);
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="PlayerHandLightAttack"){
            currentHealth=currentHealth-exp.playerAttack;
            RFX1.GetComponent<ParticleSystem>().Play();
            RFX2.GetComponent<ParticleSystem>().Play();
            punch1.Play();
            Vector3 difference=thisAngry.transform.position-player.transform.position;
            thisAngry.transform.position=new Vector3(thisAngry.transform.position.x+difference.x,thisAngry.transform.position.y,thisAngry.transform.position.z+difference.z);
            anim.SetTrigger("IsGetHit");
        }
        if(other.gameObject.tag=="PlayerHandHeavyAttack"){
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            LFX1.GetComponent<ParticleSystem>().Play();
            LFX2.GetComponent<ParticleSystem>().Play();
            punch2.Play();
            Vector3 difference=thisAngry.transform.position-player.transform.position;
            thisAngry.transform.position=new Vector3(thisAngry.transform.position.x+difference.x,thisAngry.transform.position.y,thisAngry.transform.position.z+difference.z);
            anim.SetTrigger("IsGetHit");
        }
    }
}