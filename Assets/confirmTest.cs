using UnityEngine;public class confirmTest:MonoBehaviour{
    public GameObject start,back,entertocontinue;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            start.SetActive(true);
            back.SetActive(true);
            entertocontinue.SetActive(false);
            this.gameObject.SetActive(false);}}}