using UnityEngine;public class leavePstoneHouse:MonoBehaviour{
    public GameObject mmpointerPstone,mmpointer,player,PstoneHouse,minimap,bg3,bg4,trapbgm;
    public save2 save2;
    public AudioSource opendoorsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterOstone<1&&save2.letterPstone<1){
                player.transform.position=new Vector3(419.490204f,9.36978245f,377.664581f);
                player.transform.rotation=Quaternion.Euler(0,273.36615f,0);
                opendoorsound.Play();
                trapbgm.SetActive(false);
                bg3.SetActive(true);
                PstoneHouse.SetActive(false);
                minimap.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(save2.letterOstone>0|save2.letterPstone>0){
                player.transform.position=new Vector3(419.490204f,9.36978245f,377.664581f);
                player.transform.rotation=Quaternion.Euler(0,273.36615f,0);
                opendoorsound.Play();
                trapbgm.SetActive(false);
                bg4.SetActive(true);
                PstoneHouse.SetActive(false);
                minimap.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(mmpointer!=null&&save2.finishOstone<1) mmpointer.SetActive(true);
            if(mmpointerPstone!=null&&save2.finishPstone<1) mmpointerPstone.SetActive(true);
            if(save2.finishOstone>0&&save2.finishPstone>0) mmpointer.SetActive(true);
        }
    }
}