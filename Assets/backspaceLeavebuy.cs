using UnityEngine;public class backspaceLeavebuy:MonoBehaviour{
    public GameObject Player,buyPotionPanel,buyCollider;    
    void Update(){if(Player==null){Player=GameObject.FindWithTag("Player");}
        if(Input.GetKeyDown(KeyCode.Backspace)||Input.GetKeyDown(KeyCode.Q)){                      
            buyPotionPanel.SetActive(false); Player.GetComponent<Animator>().SetBool("buy",false);
            Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            buyCollider.GetComponent<BoxCollider>().enabled=true;
        }
    }
}