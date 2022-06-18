using UnityEngine;public class leavehousepetsister:MonoBehaviour{
    public GameObject Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>20f){
            Player2.transform.position=new Vector3(375.492889f,29.8205128f,283.7901f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=20f){
            Player1.transform.position=new Vector3(387.274994f,30.3128548f,281.285004f);
            Player2.transform.position=new Vector3(375.492889f,29.8205128f,283.7901f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
    }
}