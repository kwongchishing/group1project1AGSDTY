using UnityEngine;public class saveNPClightskill:MonoBehaviour{
    public GameObject unrealBoss1,lightskill,lightskillSound,boss1diesound,pressanykeytoStartrunninggame;
    public void lightKill(){
        lightskill.SetActive(true);
        lightskillSound.SetActive(true);
        unrealBoss1.SetActive(false);
        boss1diesound.SetActive(true);
        pressanykeytoStartrunninggame.SetActive(true);}
    public void lightkillEnd(){
    lightskill.SetActive(false);
    lightskillSound.SetActive(false);
}}