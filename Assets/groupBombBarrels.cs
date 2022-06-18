using UnityEngine;public class groupBombBarrels:MonoBehaviour{
    public AudioSource bombSound,weaponhit,Playerhurt;
    public GameObject player,hitFX1spark,hitFX1light,explose1FX,explose2FX,explose3FX;
    Animator anim;
    bool trig;
    public AXE_lighting checklight;
    public wAXE_health wAXE_health;
    void Start(){
        anim=player.GetComponent<Animator>();
    }
    void Update(){
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            explose1FX.GetComponent<ParticleSystem>().Play();
            explose2FX.GetComponent<ParticleSystem>().Play();
            explose3FX.GetComponent<ParticleSystem>().Play();
            bombSound.Play(); weaponhit.Play(); Playerhurt.Play(); anim.SetTrigger("hurt");
            wAXE_health.currentHealth-=100;
            Destroy(this.gameObject);
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            explose1FX.GetComponent<ParticleSystem>().Play();
            explose2FX.GetComponent<ParticleSystem>().Play();
            explose3FX.GetComponent<ParticleSystem>().Play();
            bombSound.Play(); weaponhit.Play(); Playerhurt.Play(); anim.SetTrigger("hurt");
            wAXE_health.currentHealth-=100;
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            explose1FX.GetComponent<ParticleSystem>().Play();
            explose2FX.GetComponent<ParticleSystem>().Play();
            explose3FX.GetComponent<ParticleSystem>().Play();
            bombSound.Play(); weaponhit.Play(); Playerhurt.Play(); anim.SetTrigger("hurt");
            wAXE_health.currentHealth-=100;
            Destroy(this.gameObject);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}