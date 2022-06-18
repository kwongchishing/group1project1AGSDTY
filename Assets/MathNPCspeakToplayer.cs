using UnityEngine;public class MathNPCspeakToplayer:MonoBehaviour{
    public GameObject mathNPCspeak,enterTocontinue,player,NPCmCollider,retryText,firstTimeplaybutnotready,youhavefinishMaths;
    public Save save;public correctCount cc;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.SetActive(true);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            player.transform.position=new Vector3(319.32f,50.4061f,277.33f);
            player.transform.rotation=Quaternion.Euler(0f,-90f,0f);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            //check retry or firstplay or firstplay but not ready
            if(cc.retryOrnot>0&&save.finishMaths<1){
                retryText.SetActive(true);  //start retry talk
                enterTocontinue.SetActive(true);
                NPCmCollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else if(cc.retryOrnot<1&&cc.firstTimeandNotready>0){
                firstTimeplaybutnotready.SetActive(true);
                enterTocontinue.SetActive(true);
                NPCmCollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else if(save.finishMaths>0&&cc.retryOrnot>0){
                youhavefinishMaths.SetActive(true);
                enterTocontinue.SetActive(true);
                NPCmCollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else{
                mathNPCspeak.SetActive(true);   //start first talk
                enterTocontinue.SetActive(true);
                NPCmCollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }
}