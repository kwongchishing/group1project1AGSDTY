using UnityEngine;public class UnderGroundnewPathopen:MonoBehaviour{
    public save2 save2;public GameObject mmpointer,Dust,fireL,fireR;
    public AudioSource hugehousemove;
    void Update(){
        if(save2.finishOstone>0&&save2.finishPstone>0){
            this.GetComponent<Animator>().enabled=true;
            save2.mission3finish++;
        }
    }
    public void mmpointerreActiveiffinishOstonefirst(){
mmpointer.SetActive(true);
    }
    public void playhugehousemoveSound(){
hugehousemove.Play(); Dust.SetActive(true);
    }
    public void stophugehousemoveSound(){
        hugehousemove.Stop(); Destroy(Dust); this.GetComponent<Animator>().enabled=false;
    }
    public void fireStart(){
        fireL.SetActive(true);
        fireR.SetActive(true);
    }
}