using UnityEngine.UI;using UnityEngine;public class skillpoint4:MonoBehaviour{
    public save2 save2;
    public AudioSource unlockskill;
    public GameObject point4;
    public wAXE_health wAXE_health;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point4finish<1&&save2.point3finish>0){
            point4.GetComponent<Image>().raycastTarget=true;
        }
        if (save2.point4finish > 0)
        {
            point4.GetComponent<Image>().raycastTarget = false;
            point4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void clickpoint4(){
        point4.GetComponent<Image>().raycastTarget=false;
        point4.GetComponent<Image>().color=new Color32(255,255,255,255);
        wAXE_health.playerDefense++;
        save2.point4finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}