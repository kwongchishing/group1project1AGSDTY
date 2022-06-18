using UnityEngine;public class finishRunning:MonoBehaviour{
    public AXE_lighting AXE_lighting;
    public GameObject panelWhite,bossL,bossR,bossdown,bossup;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            panelWhite.SetActive(true);
            AXE_lighting.lighting=false;
            AXE_lighting.heavying=false;
            Destroy(bossup);
            Destroy(bossdown);
            Destroy(bossL);
            Destroy(bossR);
        }
    }
}