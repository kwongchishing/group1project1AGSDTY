using UnityEngine;public class endfly:MonoBehaviour{
    public GameObject rubbish;
    public void AlertObservers(string message){
        if(message.Equals("flyend")){
            rubbish.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}