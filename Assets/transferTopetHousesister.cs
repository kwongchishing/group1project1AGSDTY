using UnityEngine;public class transferTopetHousesister:MonoBehaviour{
    public GameObject Player2;
    public float distance;
    public Transform p1,p2;
    public save2 save2;
    public AudioSource opendoorsound;
    public GameObject Player1;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(366.445282f,-196.002228f,-402.073059f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(364.517273f,-196.002228f,-402.211731f);
                save2.isinshop=true;
            }
        }
    }
}