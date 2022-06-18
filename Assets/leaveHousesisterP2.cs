using UnityEngine;public class leaveHousesisterP2:MonoBehaviour{
    public GameObject Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>20f){
            Player2.transform.position=new Vector3(406.326416f,29.8539162f,297.622253f);
            opendoorsound.Play();            
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=20f){
            Player1.transform.position = new Vector3(406.30835f,29.8878937f,299.360901f);
            Player2.transform.position = new Vector3(406.326416f,29.8539162f,297.622253f);
            opendoorsound.Play();            
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
    }
}