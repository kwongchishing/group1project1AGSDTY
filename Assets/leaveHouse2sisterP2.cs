using UnityEngine;public class leaveHouse2sisterP2:MonoBehaviour{
    public GameObject Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>20f){
            Player2.transform.position=new Vector3(412.057434f,29.9730434f,290.288391f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=20f){
            Player1.transform.position=new Vector3(410.766846f,30.0030632f,289.141296f);
            Player2.transform.position=new Vector3(412.057434f,29.9730434f,290.288391f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
    }
}