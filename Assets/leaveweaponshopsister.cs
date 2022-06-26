using UnityEngine;public class leaveweaponshopsister:MonoBehaviour{
    public GameObject weaponbgm,newbgm1,Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>30f){
            Player2.transform.position=new Vector3(366.325531f,29.8205147f,302.237915f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=30f){
            Player1.transform.position=new Vector3(366.771484f,29.8205147f,300.874756f);
            Player2.transform.position=new Vector3(366.325531f,29.8205147f,302.237915f);
            opendoorsound.Play();
            save2.isinshop=false;
            weaponbgm.SetActive(false);
            newbgm1.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}