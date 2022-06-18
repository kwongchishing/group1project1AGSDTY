using UnityEngine;public class transferTopetHouse:MonoBehaviour{
    public AudioSource opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1,p2;
    public GameObject minimap,Player,Player2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            opendoorsound.Play();
            Player.transform.position=new Vector3(364.517273f,-196.002228f,-402.211731f);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(366.445282f,-196.002228f,-402.073059f);
            }
        }
    }
}