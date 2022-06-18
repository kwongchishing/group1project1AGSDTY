using UnityEngine;public class Sportgamestart:MonoBehaviour{
    public GameObject player,dontseeNPCpick,rubbish1,entertocontinue; public AudioSource cancelTestsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.SetActive(true);
            entertocontinue.SetActive(false);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            dontseeNPCpick.SetActive(true);
            rubbish1.SetActive(true);
            cancelTestsound.Play();
            this.gameObject.SetActive(false);}}}