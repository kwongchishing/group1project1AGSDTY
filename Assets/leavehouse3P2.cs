using UnityEngine;public class leavehouse3P2:MonoBehaviour{
    public GameObject Player1,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance>20f){
            Player2.transform.position=new Vector3(388.6651f,29.8212547f,301.131683f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&distance<=20f){
            Player1.transform.position=new Vector3(389.373657f,29.8205147f,302.91333f);
            Player2.transform.position=new Vector3(388.6651f,29.8212547f,301.131683f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
    }
}