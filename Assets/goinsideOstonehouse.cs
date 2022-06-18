using UnityEngine;public class goinsideOstonehouse:MonoBehaviour{
    public GameObject mmpointerPstone,mmpointer,realOstonehouse, Player,minimap,bg3,bg4,puzzlebgm;
    public save2 save2;
    public AudioSource opendoorsound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterOstone<1&&save2.letterPstone<1){puzzlebgm.SetActive(true);
                realOstonehouse.SetActive(true);
                Player.transform.position=new Vector3(382.180725f,68.1009827f,371.466949f);
                opendoorsound.Play();
                bg3.SetActive(false);                
                minimap.SetActive(false);
            }
            if(save2.letterOstone>0|save2.letterPstone>0){puzzlebgm.SetActive(true);
                realOstonehouse.SetActive(true);
                Player.transform.position=new Vector3(382.180725f,68.1009827f,371.466949f);
                opendoorsound.Play();
                bg4.SetActive(false);
                minimap.SetActive(false); 
            }
            if(mmpointer!=null) mmpointer.SetActive(false);
            if(mmpointerPstone!=null) mmpointerPstone.SetActive(false);
        }
    }
}