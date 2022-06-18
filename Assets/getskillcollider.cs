using UnityEngine;using UnityEngine.UI;public class getskillcollider:MonoBehaviour{
    public GameObject getskilltxt;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            getskilltxt.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            Destroy(this.gameObject);
        }
    }
}