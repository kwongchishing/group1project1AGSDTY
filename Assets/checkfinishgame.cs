using UnityEngine;public class checkfinishgame:MonoBehaviour{
    public GameObject load2newgamebutton;
    public save2 save2;
    public void iffinishgame(){
        if(save2.finishgame>0) load2newgamebutton.SetActive(true);
    }
}