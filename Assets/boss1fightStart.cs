using UnityEngine;public class boss1fightStart:MonoBehaviour{
    public GameObject player,realBoss1,unrealBoss1,leavecollider,entertocontinue;
    public AudioSource UGmusic,boss1fightSound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.GetComponent<Animator>().SetBool("stop",false);
            boss1fightSound.Play();
            UGmusic.Stop();
            realBoss1.SetActive(true);
            unrealBoss1.SetActive(false);            
            leavecollider.SetActive(false);
            Destroy(entertocontinue);
            Destroy(this.gameObject);
        }
    }
}