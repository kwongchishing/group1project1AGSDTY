using UnityEngine;public class youhavefinish:MonoBehaviour{
    public GameObject mathsNPCcollider,pressEnterornot,player,entertocontinue;
    public AudioSource cancelTestsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.SetActive(true);
            entertocontinue.SetActive(false);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.transform.position=new Vector3(319.32f,50.4061f,277.33f);
            player.transform.rotation=Quaternion.Euler(0,-90f,0);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            //player can move now
            mathsNPCcollider.SetActive(true);
            pressEnterornot.SetActive(true);
            cancelTestsound.Play();
            this.gameObject.SetActive(false);
        }
    }
}