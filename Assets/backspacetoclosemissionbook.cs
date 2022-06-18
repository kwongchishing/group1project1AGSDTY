using UnityEngine;public class backspacetoclosemissionbook:MonoBehaviour{    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Backspace)){
            this.gameObject.SetActive(false);
        }
    }
}