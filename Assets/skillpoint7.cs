using UnityEngine.UI;using UnityEngine;public class skillpoint7:MonoBehaviour{
    public save2 save2;
    public GameObject point7;
    public AudioSource unlockskill;
    public WAXE_exp WAXE_exp;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point7finish<1&&save2.point6finish>0){
            point7.GetComponent<Image>().raycastTarget=true;
        }
        if (save2.point7finish > 0)
        {
            point7.GetComponent<Image>().raycastTarget = false;
            point7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void clickpoint7(){
        point7.GetComponent<Image>().raycastTarget=false;
        point7.GetComponent<Image>().color=new Color32(255,255,255,255);
        WAXE_exp.playerAttack++;
        save2.point7finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}