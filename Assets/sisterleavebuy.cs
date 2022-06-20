using UnityEngine;
public class sisterleavebuy:MonoBehaviour{
    public GameObject Player2,buyPotionPanel,buyCollider;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Q))
        {
            buyPotionPanel.SetActive(false);
            Player2.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl1>().enabled=true;
            Player2.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            buyCollider.GetComponent<BoxCollider>().enabled=true;
            Player2.GetComponent<Animator>().SetBool("stop",false);
        }
    }
}