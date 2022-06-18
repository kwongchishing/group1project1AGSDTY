using UnityEngine;public class TransferToDhousesister:MonoBehaviour{
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
            Player2.transform.position = new Vector3(114.68000030517578f, -115.63999938964844f, 339.927978515625f);
            save2.isinshop = true;
            if (distance <= 8f)
            {
                Player1.transform.position = new Vector3(115.731598f, -116.267632f, 340.317261f);
                save2.isinshop = true;
            }
        }
    }
}