using UnityEngine;public class gameover:MonoBehaviour{
    public GameObject gameoverpanel;public AudioSource titlemusic; public Texture2D cursorArrow;
    void Start(){
        Time.timeScale=1;Cursor.SetCursor(cursorArrow,Vector2.zero,CursorMode.ForceSoftware);
    }
    public void showGameOverPanel(){
        gameoverpanel.SetActive(true);
        titlemusic.Play();
    }
}