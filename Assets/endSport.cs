using UnityEngine;public class endSport:MonoBehaviour{
    public AudioSource canceltextsound;
    public GameObject NPCcollider,dodgeimg,frontwall,backwall,windblock,AllfinishSportparent,rubbishGROUP,player,entertocontinue;
    public Save save;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            NPCcollider.SetActive(true);
            canceltextsound.Play();
            entertocontinue.SetActive(false);
            Destroy(dodgeimg);
            Destroy(frontwall);
            Destroy(backwall);
            windblock.SetActive(true);
            save.iron+=1;
            Destroy(AllfinishSportparent);
            Destroy(rubbishGROUP);}}}