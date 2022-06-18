using UnityEngine;public class anykeytoleaveText:MonoBehaviour{
    void Update(){
        if(Input.anyKeyDown){
            this.gameObject.SetActive(false);}}}