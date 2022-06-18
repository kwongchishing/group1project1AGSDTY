using UnityEngine;public class timecount:MonoBehaviour{
    public GameObject bossL,bossR,bossdown,bossup,runText2,runcount,boss1rotateSound,runcountText,runningsister;
    public AudioSource runningGameSound;
   void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            runText2.SetActive(true);
            bossup.SetActive(true);
            bossdown.SetActive(true);
            bossL.SetActive(true);
            bossR.SetActive(true);
            boss1rotateSound.SetActive(true);
            runningGameSound.Play();
            runcount.SetActive(true);
            Destroy(runningsister);
            runcountText.SetActive(true);}}}