using UnityEngine;public class finishbutlose:MonoBehaviour{
    public Save save;
    public GameObject NPCcollider,player,windblock,frontwall,backwall,NPC,entertocontinue;
    public AudioSource cancel,test2music;
    Animator anim;
    void Start(){
         save.playedbutnotwin=1;
        anim=NPC.GetComponent<Animator>();
    }
    void Update(){
        test2music.Stop();
        anim.SetTrigger("return");
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            entertocontinue.SetActive(false);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            NPCcollider.SetActive(true);
            cancel.Play();
            windblock.SetActive(true);
            frontwall.SetActive(false);
            backwall.SetActive(false);
            anim.ResetTrigger("throw");
            anim.ResetTrigger("Idlegirl");
            anim.ResetTrigger("return");
            save.gethitbyRubbish=0;
            this.gameObject.SetActive(false);}}}