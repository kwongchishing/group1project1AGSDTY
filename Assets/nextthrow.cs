using UnityEngine;public class nextthrow:MonoBehaviour{
    Animator anim;
    public GameObject NPC;
    void Start(){
        anim=NPC.GetComponent<Animator>();
        anim.SetTrigger("throw");
    }
    void Update(){
        anim.SetTrigger("throw");
    }
}