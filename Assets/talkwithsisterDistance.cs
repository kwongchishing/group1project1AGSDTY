using UnityEngine;public class talkwithsisterDistance:MonoBehaviour{
    public Transform Player;
    public GameObject talkwithsister,enterTocontinue;
    void Update(){
        if(Player==null) Player=GameObject.FindWithTag("Player").transform;
        if(Vector3.Distance(Player.transform.position,transform.position)<2.9f&&Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded")){
            Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            talkwithsister.SetActive(true);
            enterTocontinue.SetActive(true);
            Player.GetComponent<Animator>().SetBool("stop",true);
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            Player.transform.LookAt(new Vector3(transform.position.x,Player.transform.position.y,transform.position.z));
        }
    }
}