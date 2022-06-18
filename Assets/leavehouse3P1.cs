using UnityEngine;public class leavehouse3P1:MonoBehaviour{
    public GameObject player,Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if(Input.GetKeyDown(KeyCode.Return)&&distance>20f|| Input.GetKeyDown(KeyCode.E) && distance > 20f)
        {
            player.transform.position=new Vector3(389.373657f,29.8205147f,302.91333f);
            opendoorsound.Play();
            save2.isinshop=false;
            this.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&distance<=20f&&save2.isjoined== true|| Input.GetKeyDown(KeyCode.E) && distance <= 20f && save2.isjoined == true)
        {
            opendoorsound.Play();
            Player2.transform.position=new Vector3(388.6651f,29.8212547f,301.131683f);
            player.transform.position=new Vector3(389.373657f,29.8205147f,302.91333f);
            save2.isinshop=false;
        }
    }
}