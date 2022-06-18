using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class Switchsc3:MonoBehaviour{
    public Texture2D cursorArrow;public GameObject loadtext,Warning; public InputField Playername;void Start(){Cursor.SetCursor(cursorArrow,Vector2.zero,CursorMode.ForceSoftware);
    Playername.ActivateInputField();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&&Playername.text.Length>=2){
            loadtext.SetActive(true);
            Warning.SetActive(false);
            SceneManager.LoadScene("sc3");StartMessageAndName.playernamestr=Playername.text;
        }
        else if(Input.GetKeyDown(KeyCode.Return) && Playername.text.Length <2) { Warning.SetActive(true); }
    }
    public void NextScene(string sceneName){if(Playername.text.Length>=2){loadtext.SetActive(true);
            Warning.SetActive(false);
            SceneManager.LoadScene("sc3");StartMessageAndName.playernamestr=Playername.text;}else{Warning.SetActive(true);}}    
}