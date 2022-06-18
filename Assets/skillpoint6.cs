using UnityEngine.UI;using UnityEngine;public class skillpoint6:MonoBehaviour{
    public save2 save2;
    public AudioSource unlockskill;
    public GameObject point6;
    public wAXE_health wAXE_health;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point6finish<1&&save2.point5finish>0){
            point6.GetComponent<Image>().raycastTarget=true;
        }
        if (save2.point6finish > 0)
        {
            point6.GetComponent<Image>().raycastTarget = false;
            point6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void clickpoint6(){
        point6.GetComponent<Image>().raycastTarget=false;
        point6.GetComponent<Image>().color=new Color32(255,255,255,255);
        wAXE_health.playerDefense++;
        save2.point6finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}