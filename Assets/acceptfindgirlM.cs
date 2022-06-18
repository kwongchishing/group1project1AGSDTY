using UnityEngine;public class acceptfindgirlM:MonoBehaviour{
    public save2 save2;
    public GameObject leavecanvas,acceptedmission,door,talkdefmissionCanvas;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            save2.findgirlMaccept++;
            door.GetComponent<SphereCollider>().enabled=true;
            acceptedmission.SetActive(true);
            leavecanvas.SetActive(true);
            Destroy(talkdefmissionCanvas);
        }
    }
}