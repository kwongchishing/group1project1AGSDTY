using UnityEngine.UI;using UnityEngine;public class skillpoint5:MonoBehaviour{
    public save2 save2;
    public AudioSource unlockskill;
    public GameObject point5;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point5finish<1&&save2.point4finish>0){
            point5.GetComponent<Image>().raycastTarget=true;
        }
        if (save2.point5finish > 0)
        {
            point5.GetComponent<Image>().raycastTarget = false;
            point5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void clickpoint5(){
        point5.GetComponent<Image>().raycastTarget=false;
        point5.GetComponent<Image>().color=new Color32(255,255,255,255);
        save2.point5finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}