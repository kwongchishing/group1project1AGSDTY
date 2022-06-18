using UnityEngine;public class footStepSound:MonoBehaviour{
    public AudioSource Crouchsound;public GameObject turnsound2,turnsound,runsound;
    public save2 save2;
    void Update(){
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("talk and stop")|Input.GetKeyDown(KeyCode.Return)|GetComponent<Animator>().GetFloat("Forward")==0){
            turnsound2.SetActive(false); turnsound.SetActive(false); runsound.SetActive(false);
        }
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("nojump")&&Input.GetKeyDown(KeyCode.Return)){
            GetComponent<Animator>().SetFloat("Forward",0); GetComponent<Animator>().SetFloat("Turn", 0); turnsound2.SetActive(false); turnsound.SetActive(false); runsound.SetActive(false);
        }      
    }
    public void playCrouchsound(){Crouchsound.Play();}}