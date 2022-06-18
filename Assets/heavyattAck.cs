using UnityEngine;public class heavyattAck:MonoBehaviour{public GameObject heavyHand;public AudioSource heavyattackSound;public Save save;public void attackstart2(){heavyHand.SetActive(true);heavyattackSound.Play();}public void attackend2(){
        if(save.w_AXE<1) heavyHand.SetActive(false);
        GetComponent<Animator>().ResetTrigger("hurt");
    }
}