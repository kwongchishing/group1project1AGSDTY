using UnityEngine;public class showplayerinfo:MonoBehaviour{
    public GameObject backspacetoclose,playerinfoImg;
    public void showplayerInformation(){
        playerinfoImg.SetActive(true);
        backspacetoclose.SetActive(true);
    }
}