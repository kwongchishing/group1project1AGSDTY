using UnityEngine;public class asksisterforbuy:MonoBehaviour{
    public GameObject askforbuytext,buyCollider, buypotionPanel,setting,Player2;
    public AudioSource whattodoSound,readSound;
    void Update(){        
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            Player2.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl1>().enabled=false;
            Player2.GetComponent<Animator>().SetBool("stop",true);
            Player2.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            whattodoSound.Play();
            readSound.Play();
            buypotionPanel.SetActive(true);
            setting.SetActive(false);
            this.gameObject.SetActive(false);
            buyCollider.GetComponent<BoxCollider>().enabled=false;
            askforbuytext.SetActive(false);
        }
    }
}