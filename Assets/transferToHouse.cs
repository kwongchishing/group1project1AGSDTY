using UnityEngine;public class transferToHouse:MonoBehaviour{
    public AudioSource opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1,p2;
    public GameObject minimap,Player,Player2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            opendoorsound.Play();
            Player.transform.position=new Vector3(128.729355f,-131.935944f,121.860283f);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(127.553139f,-131.935211f,121.704247f);
            }
        }
    }
}