using UnityEngine;public class sistertohouse1:MonoBehaviour{
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
            Player2.transform.position=new Vector3(127.553139f,-131.935211f,121.704247f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(128.729355f,-131.935944f,121.860283f);
                save2.isinshop=true;
            }
        }
    }
}