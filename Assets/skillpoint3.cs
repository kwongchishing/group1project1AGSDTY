using UnityEngine.UI;using UnityEngine;public class skillpoint3:MonoBehaviour{
    public save2 save2;
    public GameObject point3;
    public AudioSource unlockskill;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point3finish<1&&save2.point2finish>0){
            point3.GetComponent<Image>().raycastTarget=true;
        }
        if (save2.point3finish > 0)
        {
            point3.GetComponent<Image>().raycastTarget = false;
            point3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void clickpoint3(){
        point3.GetComponent<Image>().raycastTarget=false;
        point3.GetComponent<Image>().color=new Color32(255,255,255,255);
        save2.point3finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}