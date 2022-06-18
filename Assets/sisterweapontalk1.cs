using UnityEngine;public class sisterweapontalk1:MonoBehaviour{
    public GameObject leavecanvas,NPC,enterTocontinue,door,getweapontalk1,enterpink;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            Destroy(enterpink);
            NPC.GetComponent<SphereCollider>().enabled=false;
            getweapontalk1.SetActive(true);
            enterTocontinue.SetActive(true);
            door.GetComponent<SphereCollider>().enabled=false;
            leavecanvas.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}