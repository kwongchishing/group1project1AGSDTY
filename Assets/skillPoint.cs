using UnityEngine.UI;using UnityEngine;public class skillPoint:MonoBehaviour{
    public save2 save2;
    Animator anim;
    void Start(){
        anim=GetComponent<Animator>();
    }
    void Update(){
        if(save2.totalSkillPoint>0&&save2.finishgame>0){
            anim.SetBool("haveskillpoint",true);
        }
        if(save2.totalSkillPoint<1&&save2.finishgame>0){
            anim.SetBool("haveskillpoint",false);
        }
    }
}