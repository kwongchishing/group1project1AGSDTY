using UnityEngine;public class gotoGetDodge:MonoBehaviour{
    public GameObject getDodge, minimapiconthrowhouse, minimapiconmchouse;
    public AudioSource GetdodgeAndiron;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {            
            getDodge.SetActive(true);
            GetdodgeAndiron.Play(); minimapiconthrowhouse.SetActive(false); minimapiconmchouse.SetActive(true);
            Destroy(this.gameObject);}}}