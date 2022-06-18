using UnityEngine;public class sisterstartdefensemission:MonoBehaviour{
    public GameObject TowerhealthCanvas,defensebgm, bgm1,defendtowermonster,defenseTowerFX,enter,Player1,AllcolliWall;
    public AudioSource potionshopBGM,missionstartsound;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            defenseTowerFX.GetComponent<SphereCollider>().enabled = false;
            Destroy(enter);
            Player1.transform.position=new Vector3(385.149658f,29.8205147f,303.16626f);
            save2.isinshop = false;
            potionshopBGM.Stop();
            AllcolliWall.SetActive(true);
            missionstartsound.Play();
            defendtowermonster.SetActive(true);
            bgm1.SetActive(false);
            TowerhealthCanvas.SetActive(true);
            defensebgm.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}