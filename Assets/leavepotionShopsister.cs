using UnityEngine;public class leavepotionShopsister:MonoBehaviour{
    public GameObject newbgm1,setting,buyCollider,buyPotionPanel,Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource potionShopthemeSong,opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position, p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>8f){
            Player2.transform.position=new Vector3(423.163666f,30.2492886f,288.841888f);
            Player2.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            opendoorsound.Play();
            this.gameObject.SetActive(false);
            buyPotionPanel.SetActive(false);
            Player2.GetComponent<Animator>().SetBool("nojump",false);
            save2.isinshop =false;
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=8f){
            Player1.transform.position=new Vector3(423.098633f,30.2193813f,288.461517f);
            Player1.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            Player2.transform.position=new Vector3(423.163666f,30.2492886f,288.841888f);
            Player2.transform.rotation=Quaternion.Euler(0,180.954742f,0);
            opendoorsound.Play();
            this.gameObject.SetActive(false);            
            Player1.GetComponent<Animator>().SetBool("nojump",false);
            Player2.GetComponent<Animator>().SetBool("nojump",false);
            Player1.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            Player1.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            buyCollider.GetComponent<BoxCollider>().enabled=true;
            setting.SetActive(true);
            potionShopthemeSong.Stop();
            newbgm1.SetActive(true);buyPotionPanel.SetActive(false);
            save2.isinshop = false;
        }
    }
}