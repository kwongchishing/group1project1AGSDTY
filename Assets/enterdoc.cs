using UnityEngine;public class enterdoc:MonoBehaviour{
    public GameObject document1,pickuptext;
    public AudioSource readSound;
    void Update(){
        if(Input.GetKey(KeyCode.Return)||Input.GetKey(KeyCode.E)){
            document1.SetActive(true);
            pickuptext.SetActive(false);
            readSound.Play();
        }
    }
}