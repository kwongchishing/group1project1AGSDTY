using UnityEngine;public class leaveinteresthouse:MonoBehaviour{
    public GameObject player, Player2;
    public float distance;
    public Transform p1,p2;
    public AudioSource opendoorsound;
    public save2 save2;
    void Update(){
        distance=Vector3.Distance(p1.transform.position,p2.transform.position);
        if (Input.GetKeyDown(KeyCode.Return) && distance>20f||Input.GetKeyDown(KeyCode.E)&&distance>20f){
            player.transform.position = new Vector3(352.914429f,29.862154f,295.866608f);
            opendoorsound.Play();
            save2.isinshop = false;
            this.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return) && distance <= 20f && save2.isjoined == true || Input.GetKeyDown(KeyCode.E) && distance <= 20f && save2.isjoined == true)
        {
            opendoorsound.Play();
            Player2.transform.position = new Vector3(352.682892f, 29.8205147f, 292.016449f);
            player.transform.position = new Vector3(352.914429f, 29.862154f, 295.866608f);
            save2.isinshop = false;
        }
    }
}