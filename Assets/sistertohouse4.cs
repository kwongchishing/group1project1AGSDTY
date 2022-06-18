using UnityEngine;public class sistertohouse4:MonoBehaviour{
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
            Player2.transform.position=new Vector3(574.379761f,-242.235947f,-561.596497f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(575.992859f,-242.235931f,-560.989563f);
                save2.isinshop=true;
            }
        }
    }
}