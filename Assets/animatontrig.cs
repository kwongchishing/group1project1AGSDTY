using UnityEngine;public class animatontrig:MonoBehaviour{    
    Animator anim;
    public AudioSource wait;
    public Transform P1,P2;
    void Start(){anim=GetComponent<Animator>();}
    void Update(){
        if(Vector3.Distance(P1.transform.position,transform.position)<20f||Vector3.Distance(P2.transform.position,transform.position)<20f){anim.SetTrigger("a1");}
        else{anim.ResetTrigger("a1");}
    }
    public void idlesound(){
        wait.Play();
    }
}