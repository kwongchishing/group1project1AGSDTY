using UnityEngine;public class backspacetoclosemissionbook:MonoBehaviour{    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Q))
        {
            this.gameObject.SetActive(false);
        }
    }
}