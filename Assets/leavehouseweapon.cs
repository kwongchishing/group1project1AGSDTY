using UnityEngine;public class leavehouseweapon:MonoBehaviour{
    public GameObject newbgm1,weaponbgm,player,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)&&distance>30f||Input.GetKeyDown(KeyCode.E)&& distance>30f){
            player.transform.position=new Vector3(366.771484f,29.8205147f,300.874756f);
            opendoorsound.Play();
            save2.isinshop=false;
            weaponbgm.SetActive(false);
            newbgm1.SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&distance<=30f&&save2.isjoined==true||Input.GetKeyDown(KeyCode.E)&&distance<=30f&&save2.isjoined==true){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(366.325531f,29.8205147f,302.237915f);
            player.transform.position=new Vector3(366.771484f,29.8205147f,300.874756f);
            save2.isinshop=false;
            weaponbgm.SetActive(false);
            newbgm1.SetActive(true);
        }
    }
}