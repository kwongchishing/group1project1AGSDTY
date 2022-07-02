using UnityEngine;public class sisterdodge:MonoBehaviour{
    public GameObject sister;
    Animator anim;
    void Start(){
        anim=sister.GetComponent<Animator>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.KeypadPeriod)&&!anim.GetCurrentAnimatorStateInfo(0).IsName("Dodge")&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")|anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack")|anim.GetCurrentAnimatorStateInfo(0).IsName("sisterheavycombo")|anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo2") | anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo3") | anim.GetCurrentAnimatorStateInfo(0).IsName("hurt") | anim.GetCurrentAnimatorStateInfo(0).IsName("HeavyAttack"))
        {
            anim.SetTrigger("Dodge");
        }
    }
}