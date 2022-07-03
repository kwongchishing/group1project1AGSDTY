using UnityEngine;public class sistertransferinteresthouse:MonoBehaviour{
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
            Player2.transform.position=new Vector3(-182f,-131.9f,-195.6f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(-183.65f,-131.9f,-195.9f);
                save2.isinshop=true;
            }
        }
    }
}