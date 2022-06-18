using UnityEngine;public class Clearwell3Stone:MonoBehaviour{
    public GameObject player,hitFX1spark,hitFX1light, stoneclearedtext;
    public AudioSource clearStoneSound;
    public save2 save2;
    Animator anim;
    bool trig;
    public AXE_lighting checklight;
    void Start(){
        anim=player.GetComponent<Animator>();
    }
    void Update(){
        if(trig && checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            clearStoneSound.Play();
            save2.clearwell3++;
            stoneclearedtext.SetActive(true);
            Destroy(stoneclearedtext, 4f);
            Destroy(this.gameObject);
        }
        if (trig && checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            clearStoneSound.Play();
            save2.clearwell3++;
            stoneclearedtext.SetActive(true);
            Destroy(stoneclearedtext, 4f);
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
            clearStoneSound.Play();
            save2.clearwell3++;
            stoneclearedtext.SetActive(true);
            Destroy(stoneclearedtext, 4f);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}