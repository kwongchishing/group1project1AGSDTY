using UnityEngine;public class cancelplaySport:MonoBehaviour{
    public GameObject startSporttestButton,player,NPCcollider;
    public AudioSource cancelTestsound;
    public Text0_sport sc;
    public void cancelSportTest(){
        player.SetActive(false);
        player.SetActive(true);
        player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        player.transform.position=new Vector3(312.1635f,50.406f,365.0925f);
        player.transform.rotation=Quaternion.Euler(0f,-159.473f,0f);
        player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
        startSporttestButton.SetActive(false);
        cancelTestsound.Play();
        sc.cancelCount+=1;
        NPCcollider.SetActive(true);
        this.gameObject.SetActive(false);}}