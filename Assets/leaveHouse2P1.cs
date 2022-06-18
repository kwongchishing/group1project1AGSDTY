using UnityEngine;public class leaveHouse2P1:MonoBehaviour{
    public GameObject player,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)&&distance>20f||Input.GetKeyDown(KeyCode.E)&&distance>20f)
        {
            player.transform.position=new Vector3(410.766846f,30.0030632f,289.141296f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&distance<=20f&&save2.isjoined==true||Input.GetKeyDown(KeyCode.E)&&distance<=20f&&save2.isjoined==true){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(412.057434f,29.9730434f,290.288391f);
            player.transform.position=new Vector3(410.766846f,30.0030632f, 289.141296f);
            save2.isinshop=false;
        }
    }
}