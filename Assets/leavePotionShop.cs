using UnityEngine;public class leavePotionShop:MonoBehaviour{
    GameObject player;
    public GameObject buyCollider,buyPotionPanel,Player2,newbgm1,potionHouse,minimap,setting,mmpointer,pstonepointer,oldmmpointer;
    public Ischange Ischange;
    public float distance;
    public Transform p1,p2;
    public AudioSource backgroundmusic1,opendoorsound,NPCdiemusic,potionShopSong;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        player=GameObject.FindWithTag("Player");
        if(Input.GetKeyDown(KeyCode.Return)&&Ischange.ischange<1||Input.GetKeyDown(KeyCode.E)&&Ischange.ischange<1){
            backgroundmusic1.Play();
            player.transform.position=new Vector3(423.098633f,30.2193813f,288.461517f);
            player.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            opendoorsound.Play();
            if(save2.isjoined==false&&save2.finishgame<1){
                potionHouse.SetActive(false);
            }
            minimap.SetActive(true);
            this.gameObject.SetActive(false);
            potionShopSong.Stop();
            mmpointer.SetActive(true); player.GetComponent<Animator>().SetBool("nojump",false);
            if(oldmmpointer!=null) oldmmpointer.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&Ischange.ischange>0&&save2.collectedkey<1||Input.GetKeyDown(KeyCode.E) && Ischange.ischange > 0 && save2.collectedkey < 1)
        {
            NPCdiemusic.Play();
            player.transform.position=new Vector3(423.098633f,30.2193813f,288.461517f);
            player.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            opendoorsound.Play();
            if (save2.isjoined == false && save2.finishgame < 1)
            {
                potionHouse.SetActive(false);
            }
            minimap.SetActive(true);
            this.gameObject.SetActive(false);
            setting.SetActive(true);
            potionShopSong.Stop();
            mmpointer.SetActive(true); player.GetComponent<Animator>().SetBool("nojump",false);
            if(oldmmpointer!=null) oldmmpointer.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&save2.collectedkey>0||Input.GetKeyDown(KeyCode.E) && save2.collectedkey > 0)
        {
            backgroundmusic1.Play();
            player.transform.position=new Vector3(423.098633f,30.2193813f,288.461517f);
            player.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            opendoorsound.Play();
            if (save2.isjoined == false && save2.finishgame < 1)
            {
                potionHouse.SetActive(false);
            }
            minimap.SetActive(true);
            this.gameObject.SetActive(false);
            setting.SetActive(true);
            potionShopSong.Stop(); player.GetComponent<Animator>().SetBool("nojump",false);
            if(save2.finishOstone<1&&save2.gateopened>0) mmpointer.SetActive(true);
            if(save2.finishOstone>0&&save2.finishPstone>0&&save2.gateopened>0) mmpointer.SetActive(true);
            if(save2.finishPstone<1&&pstonepointer!=null&&save2.gateopened>0) pstonepointer.SetActive(true);
            if(oldmmpointer!=null) oldmmpointer.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Return) && save2.gateopened < 1 ||Input.GetKeyDown(KeyCode.E) && save2.gateopened < 1) { mmpointer.SetActive(true); }
        if(Input.GetKeyDown(KeyCode.Return)&&save2.finishgame>0||Input.GetKeyDown(KeyCode.E) && save2.finishgame > 0)
        {
            newbgm1.SetActive(true);
                minimap.SetActive(false); save2.isinshop=false;
            if(distance<=8f&&save2.isjoined==true){
                Player2.transform.position=new Vector3(423.163666f,30.2492886f,288.841888f);
                Player2.transform.rotation=Quaternion.Euler(0,180.954742f,0);
                buyPotionPanel.SetActive(false);Player2.GetComponent<Animator>().SetBool("stop",false);
                Player2.GetComponent<Animator>().SetBool("nojump",false);
                Player2.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl1>().enabled=true;
                Player2.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                buyCollider.GetComponent<BoxCollider>().enabled=true; save2.isinshop=false;
            }
        }
    }
}