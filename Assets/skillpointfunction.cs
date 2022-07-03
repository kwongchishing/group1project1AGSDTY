using UnityEngine.UI;using UnityEngine;public class skillpointfunction:MonoBehaviour{
    public save2 save2;
    public AudioSource unlockskill;
    public GameObject point1;
    public wAXE_health wAXE_health;
    void Update(){
        if(save2.totalSkillPoint>0&&save2.point1finish<1){
            point1.GetComponent<Image>().raycastTarget=true;
        }
        if(save2.point1finish>0){
            point1.GetComponent<Image>().raycastTarget=false;
            point1.GetComponent<Image>().color=new Color32(255,255,255,255);
        }
    }
    public void clickpoint1(){
       point1.GetComponent<Image>().raycastTarget=false;
        point1.GetComponent<Image>().color=new Color32(255,255,255,255);
        wAXE_health.playerDefense++;
        save2.point1finish++;
        unlockskill.Play();
        save2.totalSkillPoint--;
    }
}