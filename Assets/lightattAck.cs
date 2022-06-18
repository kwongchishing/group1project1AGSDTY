using UnityEngine;public class lightattAck:MonoBehaviour{
    public GameObject lightHand;
    public AudioSource lightattackSound;
    public Save save;
    public void attackstart(){
        lightHand.SetActive(true);
        lightattackSound.Play();
    }
    public void attackend(){
        if(save.w_AXE<1) lightHand.SetActive(false);
        GetComponent<Animator>().ResetTrigger("hurt");
    }
}