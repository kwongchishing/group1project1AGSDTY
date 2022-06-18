using UnityEngine;public class enterdoc2:MonoBehaviour{
    public GameObject document1,pickuptext;
    public AudioSource readSound;
    void Update(){
        if(Input.GetKey(KeyCode.KeypadEnter)){
            document1.SetActive(true);
            pickuptext.SetActive(false);
            readSound.Play();
        }
    }
}