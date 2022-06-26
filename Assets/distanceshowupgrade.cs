using UnityEngine;public class distanceshowupgrade:MonoBehaviour{
    public GameObject Player,Player2,mainupgradeCanvas;
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<6.2f||Vector3.Distance(Player2.transform.position,transform.position)<6.2f){
            mainupgradeCanvas.SetActive(true);
        }
        else{
            mainupgradeCanvas.SetActive(false);
        }
    }
}