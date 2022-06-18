using UnityEngine;public class bosstalk1Text1:MonoBehaviour{
    public GameObject boss1talk2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            boss1talk2.SetActive(true);
            Destroy(this.gameObject);}}}