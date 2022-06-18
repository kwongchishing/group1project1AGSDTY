using UnityEngine;public class exithottocontrol:MonoBehaviour{
    public AudioSource cancel;
    public save2 save2;
    public GameObject p2leave,continueBTN, loadgameBTN,backtotitleBTN,howtoplayBTN,volumesetBTN;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace)){
            cancel.Play();
            this.gameObject.SetActive(false);
            continueBTN.SetActive(true);
            loadgameBTN.SetActive(true);
            backtotitleBTN.SetActive(true);
            howtoplayBTN.SetActive(true);
            volumesetBTN.SetActive(true);
            if(save2.isjoined==true){p2leave.SetActive(true);}
        }        
    }
}