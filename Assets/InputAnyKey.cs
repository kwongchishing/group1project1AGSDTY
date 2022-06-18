using UnityEngine;using UnityEngine.SceneManagement;using UnityEngine.UI;public class InputAnyKey:MonoBehaviour{
    public save2 save2;
    public GameObject load2newgamebutton,anykeytostart,playgamebutton,backbutton,optionbutton,creditsbutton,quitgame,loadgamebutton;
    public Slider slider;
    public Texture2D cursorArrow;
    void Start(){if(PlayerPrefs.HasKey("Volume")){slider.value=PlayerPrefs.GetFloat("Volume");} Cursor.SetCursor(cursorArrow,Vector2.zero,CursorMode.ForceSoftware);}
    void Update(){
        Time.timeScale=1;if(Input.anyKey){
            if(PlayerPrefs.HasKey("finishgame")){
                save2.finishgame=PlayerPrefs.GetFloat("finishgame");
            }
                anykeytostart.SetActive(false); playgamebutton.SetActive(true); backbutton.SetActive(true); optionbutton.SetActive(true); creditsbutton.SetActive(true); quitgame.SetActive(true); loadgamebutton.SetActive(true);
            if(save2.finishgame>0) load2newgamebutton.SetActive(true);
        }
    }
}