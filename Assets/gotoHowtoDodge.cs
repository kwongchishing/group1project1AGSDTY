using UnityEngine;public class gotoHowtoDodge:MonoBehaviour{
    public AudioSource GetdodgeAndiron;
    public GameObject DodgeScript,howtoDodgeText;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {            
            howtoDodgeText.SetActive(true);
            GetdodgeAndiron.Play();
            DodgeScript.SetActive(true);
            Destroy(this.gameObject);}}}