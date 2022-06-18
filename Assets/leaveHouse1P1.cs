using UnityEngine;public class leaveHouse1P1:MonoBehaviour{
    public GameObject player,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)&&distance>20f|| Input.GetKeyDown(KeyCode.E) && distance > 20f)
        {
            player.transform.position=new Vector3(406.30835f,29.8878937f,299.360901f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Return)&&distance<=20f&&save2.isjoined==true|| Input.GetKeyDown(KeyCode.E) && distance <= 20f && save2.isjoined == true)
        {
            opendoorsound.Play();
            Player2.transform.position=new Vector3(406.326416f,29.8539162f,297.622253f);
            player.transform.position=new Vector3(406.30835f,29.8878937f,299.360901f);
            save2.isinshop=false;
            }        
    }
}