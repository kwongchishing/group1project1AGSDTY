using UnityEngine;public class animatontrig:MonoBehaviour{    
    Animator anim;
    void Start(){anim=GetComponent<Animator>();}
    void Update(){
        anim.SetTrigger("a1");
    }
}