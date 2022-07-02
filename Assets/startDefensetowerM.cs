using UnityEngine;public class startDefensetowerM:MonoBehaviour{
    public save2 save2;
    public GameObject towerFX,leavecanvas, acceptedmission,door,talkdefmissionCanvas;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            save2.defenseMaccept++;
            door.GetComponent<SphereCollider>().enabled=true;
            acceptedmission.SetActive(true);
            leavecanvas.SetActive(true);
            Destroy(talkdefmissionCanvas);
            towerFX.SetActive(true);
        }
    }
}