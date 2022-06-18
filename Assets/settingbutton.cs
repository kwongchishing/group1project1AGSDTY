using UnityEngine;public class settingbutton:MonoBehaviour{
    public GameObject p2leave,settingpanel;
    public AudioSource readSound;
    public save2 save2;
    public void opensettingmenu(){this.gameObject.SetActive(false);
        settingpanel.SetActive(true);readSound.Play();
        if(save2.isjoined==true){p2leave.SetActive(true);} } }