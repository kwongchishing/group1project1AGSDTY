using UnityEngine;public class transfertohouse2:MonoBehaviour{
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
            Player.transform.position=new Vector3(981.454529f,-117.619949f,-114.80114f);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(983.2887573242188f,-116.91465759277344f,-115.69998168945313f);
            }
        }
    }
}