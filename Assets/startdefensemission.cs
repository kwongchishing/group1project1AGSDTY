using UnityEngine;public class startdefensemission:MonoBehaviour{
    public GameObject TowerhealthCanvas,defensebgm,bgm1,defendtowermonster,defenseTowerFX,sisterenter,Player2,AllcolliWall;
    public AudioSource missionstartsound;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){            
            defenseTowerFX.GetComponent<SphereCollider>().enabled=false;            
            Destroy(sisterenter);
            if(save2.isjoined==true){
                Player2.transform.position=new Vector3(385.149658f,29.8205147f,303.16626f);
                save2.isinshop=false;
            }
            AllcolliWall.SetActive(true);
            missionstartsound.Play();
            defendtowermonster.SetActive(true);
            bgm1.SetActive(false);
            defensebgm.SetActive(true);
            TowerhealthCanvas.SetActive(true);            
            Destroy(this.gameObject);
        }
    }
}