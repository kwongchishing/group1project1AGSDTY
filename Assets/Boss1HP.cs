using UnityEngine;public class Boss1HP:MonoBehaviour{
    public AXE_lighting AXE_lighting;
    public float currentHealth,maxHealth;
    public WAXE_exp exp;
    public bool trig;
    public AXE_lighting checklight;
    public GameObject player,thisBossobject,Player,unrealboss1,bosstalkafterLose,anykeytoplayanimation,hitFX1spark,hitFX1light,blood1FX,blood2FX,blood3FX;
    public AudioSource weaponhitSound,boss1hurt;
    public int dropmoney;
    public save2 save2;
    void Start(){
        currentHealth=3500f;
        maxHealth=3500f;
        dropmoney=Random.Range(19,41);
    }
    void Update(){
        if(trig && checklight.lighting){
            currentHealth=currentHealth-exp.playerAttack;
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            weaponhitSound.Play();boss1hurt.Play();
            Vector3 difference = (thisBossobject.transform.position - player.transform.position) / 440;
            thisBossobject.transform.position = new Vector3(thisBossobject.transform.position.x + difference.x, thisBossobject.transform.position.y, thisBossobject.transform.position.z + difference.z);
        }
        if(trig && checklight.heavying){
            currentHealth=currentHealth-exp.playerAttack*1.9f;
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            blood1FX.GetComponent<ParticleSystem>().Play();
            blood2FX.GetComponent<ParticleSystem>().Play();
            blood3FX.GetComponent<ParticleSystem>().Play();
            weaponhitSound.Play();boss1hurt.Play(); Vector3 difference = (thisBossobject.transform.position - player.transform.position) / 440;
            thisBossobject.transform.position = new Vector3(thisBossobject.transform.position.x + difference.x, thisBossobject.transform.position.y, thisBossobject.transform.position.z + difference.z);
        }
        if(currentHealth<=0){
            exp.currentExp+=250;
            save2.currentMoney+=dropmoney;save2.goodbadcount-=4;
            Destroy(thisBossobject);
            AXE_lighting.lighting=false;
            AXE_lighting.heavying=false;
            Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            Player.transform.position=new Vector3(-9.18177128f,0.0672587752f,-302.720001f);
            Player.transform.rotation=Quaternion.Euler(0,90.0147095f,0);
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            Player.GetComponent<Animator>().SetBool("stop",true);
            unrealboss1.SetActive(true);
            bosstalkafterLose.SetActive(true);
            anykeytoplayanimation.SetActive(true);           
        }
    }
void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            currentHealth=currentHealth-exp.playerAttack*12f; Vector3 difference = (thisBossobject.transform.position - player.transform.position) /2.5f;
            thisBossobject.transform.position = new Vector3(thisBossobject.transform.position.x + difference.x, thisBossobject.transform.position.y, thisBossobject.transform.position.z + difference.z);
        }
    }   
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}