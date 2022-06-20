using UnityEngine;public class backspacetoclose:MonoBehaviour{
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Q))
        {
            this.gameObject.SetActive(false);
        }
    }
}