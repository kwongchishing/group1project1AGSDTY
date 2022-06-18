using UnityEngine;public class sportGamebegin:MonoBehaviour{
    public GameObject Rubbish;
    Animator anim;
    Animator rubbish;
    void Start(){
        anim=GetComponent<Animator>();
        rubbish=Rubbish.GetComponent<Animator>();
    }
}