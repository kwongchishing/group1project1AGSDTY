using UnityEngine;public class finishtesttalk:MonoBehaviour{
    public GameObject player,NPCcollider,entertocontinue;
    public AudioSource cancelTestsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            cancelTestsound.Play();
            entertocontinue.SetActive(false);
            NPCcollider.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}