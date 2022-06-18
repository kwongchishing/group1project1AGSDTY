using UnityEngine;public class goinsidePstoneHouse:MonoBehaviour{
    public GameObject mmpointerPstone,mmpointer, realPstonehouse, Player,minimap,bg3,bg4,trapbgmusic,stepbutton;
    public save2 save2;
    public AudioSource opendoorsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterOstone<1&&save2.letterPstone<1){
                realPstonehouse.SetActive(true);
                Player.transform.position=new Vector3(0.454466403f,0.0815161468f,-30.6766453f);
                opendoorsound.Play();
                bg3.SetActive(false);
                minimap.SetActive(false);
            }
            if(save2.letterOstone>0|save2.letterPstone>0){
                realPstonehouse.SetActive(true);
                Player.transform.position=new Vector3(0.454466403f,0.0815161468f,-30.6766453f);
                opendoorsound.Play();
                bg4.SetActive(false);
                minimap.SetActive(false);
            }
            if(save2.trapisstep>0){
                Destroy(stepbutton);
                trapbgmusic.SetActive(true);
            }
            if(mmpointer!=null) mmpointer.SetActive(false);
            if(mmpointerPstone!=null) mmpointerPstone.SetActive(false);
        }
    }
}