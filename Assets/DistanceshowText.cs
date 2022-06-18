using UnityEngine;public class DistanceshowText:MonoBehaviour{
    public GameObject Player,Player2,showtext,showtextpink;
    void Update(){
        if(Vector3.Distance(Player.transform.position,transform.position)<3.4f){
            showtext.SetActive(true);
        }
        else{
            showtext.SetActive(false);
        }
        if (Vector3.Distance(Player2.transform.position, transform.position) < 3.4f)
        {
            showtextpink.SetActive(true);
        }
        else
        {
            showtextpink.SetActive(false);
        }
    }
}