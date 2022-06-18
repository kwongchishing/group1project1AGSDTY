using UnityEngine;using UnityEngine.SceneManagement;public class loadgame:MonoBehaviour{
    public save2 save2;
    public void loadGame(){
        if(PlayerPrefs.HasKey("ActiveScene")){int levelToLoad=PlayerPrefs.GetInt("ActiveScene");SceneManager.LoadScene(levelToLoad);}
        if(save2.finishgame>0){
            SceneManager.LoadScene("sc3");
        }
    }}