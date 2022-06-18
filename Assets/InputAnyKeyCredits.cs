using UnityEngine;using UnityEngine.SceneManagement;public class InputAnyKeyCredits:MonoBehaviour{
    public save2 save2; 
        public GameObject load2newgamebutton,creditsname,playgamebutton,optionbutton,creditsbutton,quitgame,backbutton,loadgamebutton;void Update(){if(Input.anyKey){creditsname.SetActive(false);playgamebutton.SetActive(true);quitgame.SetActive(true);creditsbutton.SetActive(true);optionbutton.SetActive(true);backbutton.SetActive(true);loadgamebutton.SetActive(true); 
            if(save2.finishgame>0) load2newgamebutton.SetActive(true); } }}