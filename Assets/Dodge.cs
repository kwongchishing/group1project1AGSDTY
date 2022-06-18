using UnityEngine;public class Dodge:MonoBehaviour{
    public GameObject player;
    Animator anim;
    void Start(){
        anim=player.GetComponent<Animator>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.X)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")&&!anim.GetCurrentAnimatorStateInfo(0).IsName("Dodge")){
            anim.SetTrigger("Dodge");
        }
        if(Input.GetKeyDown(KeyCode.X)&&anim.GetCurrentAnimatorStateInfo(0).IsName("HeavyAttack")|anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack")|anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo2")|anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo3")|anim.GetCurrentAnimatorStateInfo(0).IsName("hurt")|anim.GetCurrentAnimatorStateInfo(0).IsName("heavyaxeCombo2")){
            anim.SetTrigger("DodgeWhenAttack");
        }
    }
}