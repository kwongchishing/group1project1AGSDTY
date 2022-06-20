using UnityEngine;public class backspacecloseMenu:MonoBehaviour{
    public GameObject Setting,settingPanel;
    public AudioSource cancelsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Backspace)||Input.GetKeyDown(KeyCode.Q)){
            settingPanel.SetActive(false);
            Setting.SetActive(true);
            cancelsound.Play();
        }
    }
}
