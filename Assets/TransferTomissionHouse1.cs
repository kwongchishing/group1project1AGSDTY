using UnityEngine;public class TransferTomissionHouse1:MonoBehaviour{
    public AudioSource opendoorsound;
    public save2 save2;
    public float distance;
    public Transform p1, p2;
    public GameObject minimap,Player,Player2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            opendoorsound.Play();
            Player.transform.position = new Vector3(115.731598f, -116.267632f, 340.317261f);
            Player.transform.rotation=Quaternion.Euler(0,203.380219f,0);
            save2.isinshop=true;
            minimap.SetActive(false);
            if(distance<=8f&&save2.isjoined==true){
                save2.isinshop=true;
                Player2.transform.position=new Vector3(114.68000030517578f, -115.63999938964844f, 339.927978515625f);
            }
        }
    }
}