using UnityEngine;public class leaveDestroynew2gamepanel:MonoBehaviour{
    public GameObject newgame2startPanel;
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
           Destroy(newgame2startPanel);
            Destroy(this.gameObject);
        }        
    }
}
