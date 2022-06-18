using UnityEngine;public class pinkweapontalk1:MonoBehaviour{
    public GameObject leavecanvas, NPC,enterTocontinue,door,getweapontalk1,enter;
    void Update(){
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            Destroy(enter);
            NPC.GetComponent<SphereCollider>().enabled=false;
            getweapontalk1.SetActive(true);
            enterTocontinue.SetActive(true);
            door.GetComponent<SphereCollider>().enabled=false;
            leavecanvas.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}