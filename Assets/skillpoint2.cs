using UnityEngine.UI;using UnityEngine;public class skillpoint2:MonoBehaviour{
    public save2 save2;
    public GameObject point2;
    public AudioSource unlockskill;
    public WAXE_exp WAXE_exp;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point2finish<1&&save2.point1finish>0){
            point2.GetComponent<Image>().raycastTarget=true;
        }
        if(save2.point2finish>0){
            point2.GetComponent<Image>().raycastTarget=false;
            point2.GetComponent<Image>().color=new Color32(255,255,255,255);
        }
    }
    public void clickpoint2(){
        point2.GetComponent<Image>().raycastTarget=false;
        point2.GetComponent<Image>().color=new Color32(255,255,255,255);
        WAXE_exp.playerAttack++;
        save2.point2finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}