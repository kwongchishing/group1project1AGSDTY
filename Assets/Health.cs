using UnityEngine.SceneManagement;using UnityEngine;using UnityEngine.UI;public class Health:MonoBehaviour{
    public float maxHealth=100.0f;
    public float currentHealth,angryhitcount;
    public float playerDefense=1.0f;
    public AudioSource eatpotion,noitems;
    public GameObject healParticle1,healParticle2;
    public Save save;
    public save2 save2;
    void Start(){        
            currentHealth=maxHealth;}
    void Update(){
        if(currentHealth<=0){
            Time.timeScale=0;
            SceneManager.LoadScene("playerdie");
        }
        if(currentHealth>0 && Input.GetKeyDown(KeyCode.H)){
             if(save2.currentpotion>0){
                currentHealth+=20;
                eatpotion.Play();
                save2.currentpotion--;
                healParticle1.GetComponent<ParticleSystem>().Play();healParticle2.GetComponent<ParticleSystem>().Play();
            }
            else{noitems.Play();}
        }
        if(currentHealth>maxHealth){currentHealth=maxHealth;}
        if(angryhitcount>=0.2f){
            GetComponent<Animator>().SetTrigger("hurt");
            angryhitcount=0;
        }
    }
    void OnTriggerEnter(Collider monster1){
        if(monster1.gameObject.tag=="AngryLogBody"){            
            currentHealth=currentHealth-0.06f/playerDefense;
            angryhitcount+=0.047f;
        }
        if(monster1.gameObject.tag=="Angrylogweapon"){
             currentHealth=currentHealth-0.5f/playerDefense;
            angryhitcount+=0.047f;
        }
        if(monster1.gameObject.tag=="rubbish"){
            currentHealth=currentHealth-3f/playerDefense;GetComponent<Animator>().SetTrigger("hurt");
        }        
    }
void OnTriggerStay(Collider monster1){
        if(monster1.gameObject.tag=="AngryLogBody"){            
            currentHealth=currentHealth-0.06f/playerDefense*Time.deltaTime;
            angryhitcount+=0.13f*Time.deltaTime;            
        }
        if(monster1.gameObject.tag=="Angrylogweapon"){            
            currentHealth=currentHealth-0.5f/playerDefense*Time.deltaTime;
            angryhitcount+=0.2f*Time.deltaTime;            
        }
    }
    void OnTriggerExit(Collider monster1){
        if(monster1.gameObject.tag=="AngryLogBody"){angryhitcount=0;}
        if(monster1.gameObject.tag=="Angrylogweapon"){angryhitcount=0;}
    }
}