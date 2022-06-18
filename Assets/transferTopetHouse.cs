using UnityEngine;public class transferTopetHouse:MonoBehaviour{
    public AudioSource opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1, p2;
    public GameObject minimap,Player,Player2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            opendoorsound.Play();
            Player.transform.position=new Vector3(364.2533264160156f,-196.0609893798828f,-405.95867919921877f);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop = true;
                Player2.transform.position=new Vector3(574.379761f,-242.235947f,-561.596497f);
            }
        }
    }
}