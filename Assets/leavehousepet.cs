using UnityEngine;public class leavehousepet:MonoBehaviour{
    public GameObject player,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position, p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)&& distance>20f||Input.GetKeyDown(KeyCode.E)&&distance>20f){
            player.transform.position=new Vector3(378.294281f,29.8205147f,282.979858f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&distance<=20f&&save2.isjoined==true||Input.GetKeyDown(KeyCode.E)&&distance<=20f&&save2.isjoined==true){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(375.492889f,29.8205128f,283.7901f);
            player.transform.position=new Vector3(387.274994f,30.3128548f,281.285004f);
            save2.isinshop = false;
        }
    }
}