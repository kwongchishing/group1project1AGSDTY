using UnityEngine;public class changebg1:MonoBehaviour{
    public GameObject BG3,BG1,BG4; public save2 save2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"&&save2.collectedkey>0&&save2.letterOstone<1&&save2.letterPstone<1){
            BG3.SetActive(false);BG1.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.collectedkey>0&&save2.letterOstone>0){
            BG3.SetActive(false);BG4.SetActive(false); BG1.SetActive(true);
        }
        if(other.gameObject.tag=="Player"&&save2.collectedkey>0&&save2.letterPstone>0){
            BG3.SetActive(false); BG4.SetActive(false); BG1.SetActive(true);
        }
    }
}