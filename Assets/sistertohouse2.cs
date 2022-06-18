using UnityEngine;public class sistertohouse2:MonoBehaviour{
    public GameObject Player2;
    public float distance;
    public Transform p1, p2;
    public save2 save2;
    public AudioSource opendoorsound;
    public GameObject Player1;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            opendoorsound.Play();
            Player2.transform.position=new Vector3(983.2887573242188f,-116.91465759277344f,-115.69998168945313f);
            save2.isinshop=true;
            if(distance<=8f){
                Player1.transform.position=new Vector3(981.454529f,-117.619949f,-114.80114f);
                save2.isinshop=true;
            }
        }
    }
}