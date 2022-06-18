using UnityEngine;
public class brokentheCage:MonoBehaviour{
    public save2 save2;
    public bool trig=false;
    public AudioSource breakcagesound;
    public GameObject Player;
    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="AXE"){
            trig=true;
        }
        if(other.gameObject.tag=="combo3storm"){
            Destroy(this.gameObject);
            save2.cageIsdestroy+=1;
            breakcagesound.Play();
        }
    }
    void Update(){
        if(Input.GetButtonDown("Fire1")&&trig&&Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded")){ 
            Destroy(this.gameObject);
            save2.cageIsdestroy+=1;
            breakcagesound.Play();
        }
        if(Input.GetButtonDown("Fire2")&&trig&&Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded")){ 
            Destroy(this.gameObject);
            save2.cageIsdestroy+=1;
            breakcagesound.Play();
        }
    }
}