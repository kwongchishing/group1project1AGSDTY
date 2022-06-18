using UnityEngine;public class petstartfunction:MonoBehaviour{
    public save2 save2;
    public GameObject NPC,leavecanvas,door,talkcanvaspet,fakepet,realpet;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            save2.petStart++;
            Destroy(fakepet);
            realpet.SetActive(true);
            NPC.GetComponent<SphereCollider>().enabled=false;
            door.GetComponent<SphereCollider>().enabled=true;
            leavecanvas.SetActive(true);
            Destroy(talkcanvaspet);
        }
    }
}