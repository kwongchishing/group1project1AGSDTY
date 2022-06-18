using UnityEngine;public class AXE_Text2:MonoBehaviour{
    public GameObject AXE_Text3,player,brokenaxedetector,entertocontinue;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            AXE_Text3.SetActive(true);
            entertocontinue.SetActive(true);
            Destroy(brokenaxedetector);
            player.SetActive(false);
            player.SetActive(true);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            Destroy(this.gameObject);
        }  
    }
}