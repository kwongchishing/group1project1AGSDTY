using UnityEngine;public class changebg3:MonoBehaviour{
    public GameObject BG1,BG3,BG4;
    public save2 save2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save2.letterOstone<1&&save2.letterPstone<1){
            BG1.SetActive(false); 
            BG3.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.letterOstone>0){
            BG1.SetActive(false);
            BG4.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.letterPstone<1){
            BG1.SetActive(false);
            BG3.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.letterPstone>0){
            BG1.SetActive(false);
            BG4.SetActive(true);
        }
    }
}