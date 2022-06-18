using UnityEngine;public class leaveOstoneHouse:MonoBehaviour{
    public GameObject mmpointer,mmpointerPstone,player,OstoneHouse,minimap,bg3,bg4,puzzlebgm;
    public save2 save2;
    public AudioSource opendoorsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterOstone<1&&save2.letterPstone<1){
                player.transform.position=new Vector3(386.077515f,8.82023431f,372.693878f);
                player.transform.rotation=Quaternion.Euler(0,1.28493237f,0);
                opendoorsound.Play();
                puzzlebgm.SetActive(false);
                bg3.SetActive(true);
                OstoneHouse.SetActive(false);
                minimap.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(save2.letterOstone>0|save2.letterPstone>0){
                player.transform.position=new Vector3(386.077515f,8.82023431f,372.693878f);
                player.transform.rotation=Quaternion.Euler(0,1.28493237f,0);
                opendoorsound.Play();
                puzzlebgm.SetActive(false);
                bg4.SetActive(true);
                OstoneHouse.SetActive(false);
                minimap.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(mmpointer!=null&&save2.finishOstone<1) mmpointer.SetActive(true);
            if(mmpointerPstone!=null&&save2.finishPstone<1) mmpointerPstone.SetActive(true);
            if(save2.finishOstone>0&&save2.finishPstone>0) mmpointer.SetActive(true);
        }
    }
}