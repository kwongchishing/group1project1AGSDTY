using UnityEngine;public class lookatmainmissionhouse1:MonoBehaviour{
    public Save save;
    public GameObject mmhouse1,mmhouse2,UGwell,AngryLog001;
    public Ischange Ischange;
    void Update(){
        if(save.getbrokenaxe<1) transform.LookAt(new Vector3(AngryLog001.transform.position.x,AngryLog001.transform.position.y,AngryLog001.transform.position.z));
        if(save.getbrokenaxe>0&&save.finishMaths<1) transform.LookAt(new Vector3(mmhouse1.transform.position.x,mmhouse1.transform.position.y,mmhouse1.transform.position.z));
        if(save.finishMaths>0&&save.getDodge<1) transform.LookAt(new Vector3(mmhouse2.transform.position.x,mmhouse2.transform.position.y,mmhouse2.transform.position.z));
        if(save.getDodge>0&&Ischange.ischange<1) transform.LookAt(new Vector3(mmhouse1.transform.position.x,mmhouse1.transform.position.y,mmhouse1.transform.position.z));
        if(Ischange.ischange>0) transform.LookAt(new Vector3(UGwell.transform.position.x,UGwell.transform.position.y,UGwell.transform.position.z));
    }
}