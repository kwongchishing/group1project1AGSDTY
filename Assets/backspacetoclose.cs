using UnityEngine;public class backspacetoclose:MonoBehaviour{
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace)){
            this.gameObject.SetActive(false);
        }
    }
}