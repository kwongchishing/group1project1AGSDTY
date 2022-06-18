using UnityEngine;using UnityEngine.AI;public class rubbishchasePlayer:MonoBehaviour{
    NavMeshAgent NM;
    NavMeshAgent NMpick;
    float x,y,z;
    Vector3 pos;
    public AudioSource success,notsuccess,gethurt;
    public Save save;
    public GameObject nextRubbish,NPC;
    Animator anim;
    void Start(){
        x=Random.Range(338.9f,337.9f);
        y=Random.Range(50.4061f,50.406f); 
        z=Random.Range(376.3f,359.7f);
        pos=new Vector3(x,y,z);
        NM=GetComponent<NavMeshAgent>();
        NM.SetDestination(pos);
        anim=NPC.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag=="rubbishcollect"){
            this.gameObject.SetActive(false);
            success.Play();
            transform.localPosition=new Vector3(-3.90000558f,0.999000251f,-2.18200088f);
            nextRubbish.SetActive(true);
        }
        if(other.gameObject.tag=="Player"){
            this.gameObject.SetActive(false);
            notsuccess.Play();
            gethurt.Play();
            save.gethitbyRubbish+=1;
            transform.localPosition=new Vector3(-3.90000558f,0.999000251f,-2.18200088f);
            nextRubbish.SetActive(true);
        }
    }
    void Update(){NM.SetDestination(pos);}
}