using UnityEngine;public class talkwithsisterEnd:MonoBehaviour{
    public GameObject player,talkwithsister;
    public save2 save2;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<Animator>().SetBool("stop",false);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            save2.talkedwithsister++;
            Destroy(talkwithsister);
        }
    }
    }