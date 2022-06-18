using UnityEngine;public class NotbombBarrel:MonoBehaviour{
    public AudioSource weaponhit,bombSound;
    public save2 save2;
    public GameObject letterOstone,groupBarrel,minimapiconOstone,hitFX1spark,hitFX1light,WhereOstoneNotes,exploseFX1,exploseFX2,exploseFX3;
    bool trig;
    public AXE_lighting checklight;
    void Update(){
        if(trig&&checklight.lighting){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play(); weaponhit.Play();
            Destroy(this.gameObject);
            WhereOstoneNotes.SetActive(true); bombSound.Play();
            Destroy(groupBarrel);
            exploseFX1.GetComponent<ParticleSystem>().Play();
            exploseFX2.GetComponent<ParticleSystem>().Play();
            exploseFX3.GetComponent<ParticleSystem>().Play();
            letterOstone.SetActive(true);
            Destroy(minimapiconOstone);
            save2.finishBombgame++;
        }
        if(trig&&checklight.heavying){
            hitFX1spark.GetComponent<ParticleSystem>().Play();
            hitFX1light.GetComponent<ParticleSystem>().Play();
            weaponhit.Play();  
            Destroy(this.gameObject);
            WhereOstoneNotes.SetActive(true); bombSound.Play();
            Destroy(groupBarrel);
            exploseFX1.GetComponent<ParticleSystem>().Play();
            exploseFX2.GetComponent<ParticleSystem>().Play();
            exploseFX3.GetComponent<ParticleSystem>().Play();
            letterOstone.SetActive(true);
            Destroy(minimapiconOstone);
            save2.finishBombgame++;
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=false;
        }
    }
}