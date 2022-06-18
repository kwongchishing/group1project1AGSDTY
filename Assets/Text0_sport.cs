using UnityEngine;public class Text0_sport:MonoBehaviour{
    public GameObject entertocontinue,nextText,player,Text1_1,NPCcollider,youhavefinishText,playedbutnotwinText;public float cancelCount;public Save save;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            if(cancelCount>0&&save.iron<1&&save.playedbutnotwin<1){//first timeplay and cancel
                Text1_1.SetActive(true);
                player.SetActive(false);
                player.SetActive(true);
                entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else if(cancelCount<1&&save.iron<1&&save.playedbutnotwin<1){//have not finish and have not start yet
                nextText.SetActive(true);
                player.SetActive(false);
                player.SetActive(true);
                entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else if(save.iron>0){
                youhavefinishText.SetActive(true);//finished
                player.SetActive(false);
                player.SetActive(true);
                entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f, 50.406f, 365.0925f);
                player.transform.rotation=Quaternion.Euler(0f, -159.473f, 0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else if(save.playedbutnotwin>0){
                playedbutnotwinText.SetActive(true);//finished but lose
                player.SetActive(false);
                player.SetActive(true);
                entertocontinue.SetActive(true);
                player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
                player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
                player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
                player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                NPCcollider.SetActive(false);
                this.gameObject.SetActive(false);
            }
        }
    }
}