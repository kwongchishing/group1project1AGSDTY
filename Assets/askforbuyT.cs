using UnityEngine;public class askforbuyT:MonoBehaviour{
    public GameObject asksisterforbuyText,buyCollider,buypotionPanel,setting,Player;public AXE_lighting AXE_lighting;
    public AudioSource whattodoSound,readSound;
    void Update(){if(Player==null){Player=GameObject.FindWithTag("Player");}
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E))
        {Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=false;
            Player.GetComponent<Animator>().SetBool("buy",true);
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezePositionX|RigidbodyConstraints.FreezePositionZ|RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            AXE_lighting.lighting=false;
            AXE_lighting.heavying=false;                           
            whattodoSound.Play();
            readSound.Play();
            buypotionPanel.SetActive(true);            
            setting.SetActive(false);
            this.gameObject.SetActive(false);          
            buyCollider.GetComponent<BoxCollider>().enabled=false;
            asksisterforbuyText.SetActive(false);
        }
        }    }