using UnityEngine;using UnityEngine.SceneManagement;public class settingfunction:MonoBehaviour{
    public AudioSource readsound,cancelSound;
    public save2 save2;
    public Transform Camera,emptyobject,sisterwait,sisteruse;
    public GameObject p2leaveBTN,footstepRoad,Player,mecamera,splitscreencamera,sisterwaitforjoin,sistercontroll,howtoplayBTN,howtoplaynotes,continueBTN,backtomenuBTN,volumesetBTN,loadgameBTN,panel,settingicon,nosave,slider;
    public void closesetting(){
        panel.SetActive(false);
        settingicon.SetActive(true);
        cancelSound.Play();
    }
    public void backtotitle(){
        SceneManager.LoadScene(0);
        cancelSound.Play();
        Time.timeScale = 1;
    }
    public void volume(){
        continueBTN.SetActive(false); cancelSound.Play();
        backtomenuBTN.SetActive(false);
        loadgameBTN.SetActive(false);
        howtoplayBTN.SetActive(false);
        slider.SetActive(true);
        this.gameObject.SetActive(false);
        p2leaveBTN.SetActive(false);
    }
    public void VolumepressSave(){
        continueBTN.SetActive(true);
        volumesetBTN.SetActive(true);
        backtomenuBTN.SetActive(true);
        loadgameBTN.SetActive(true);
        howtoplayBTN.SetActive(true);
        slider.SetActive(false); cancelSound.Play();
        if(save2.isjoined==true){p2leaveBTN.SetActive(true);}
    }
    public void LoadGame(){
        if(PlayerPrefs.HasKey("ActiveScene")){int levelToLoad=PlayerPrefs.GetInt("ActiveScene"); SceneManager.LoadScene(levelToLoad); cancelSound.Play(); }
        else{nosave.SetActive(true);cancelSound.Play();}
    }
    public void howtoplay(){
        readsound.Play();
        continueBTN.SetActive(false);
        backtomenuBTN.SetActive(false);
        loadgameBTN.SetActive(false);
        volumesetBTN.SetActive(false);
        howtoplaynotes.SetActive(true);
        this.gameObject.SetActive(false); p2leaveBTN.SetActive(false);
    }
    public void p2leave(){
        save2.isjoined=false;
        cancelSound.Play();
        panel.SetActive(false);
        settingicon.SetActive(true);
        sisterwaitforjoin.SetActive(true);
        sistercontroll.SetActive(false);
        splitscreencamera.SetActive(false);
        mecamera.transform.parent=Player.transform;
        Camera.position=emptyobject.position;
        Camera.rotation=emptyobject.rotation;
        mecamera.SetActive(true);
        sisteruse.position=sisterwait.position;
        footstepRoad.SetActive(true);        
    }
}