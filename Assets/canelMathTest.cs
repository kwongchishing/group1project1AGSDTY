using UnityEngine;public class canelMathTest:MonoBehaviour{
    public GameObject startMathtestButton,mathsNPCcollider,pressEnterornot,player;
    public AudioSource cancelTestsound;
    public correctCount cc;
    public void cancelMathTest(){        
        player.SetActive(false);
        player.SetActive(true);
        player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        player.transform.position=new Vector3(319.32f,50.4061f,277.33f);
        player.transform.rotation=Quaternion.Euler(0f,-90f,0f);
        player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
        startMathtestButton.SetActive(false);
        mathsNPCcollider.SetActive(true);
        pressEnterornot.SetActive(true);
        cancelTestsound.Play();
        cc.firstTimeandNotready+=1;
        this.gameObject.SetActive(false);
    }
}