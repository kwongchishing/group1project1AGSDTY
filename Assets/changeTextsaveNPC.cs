using UnityEngine;using UnityEngine.UI;public class changeTextsaveNPC:MonoBehaviour{
    public save2 save2;
    public Text NPCtext;
    void Start(){
        if(save2.collectedkey>0){NPCtext.text="左翼天使：其實人類一早就視你為敵人......按下Enter / E鍵，我會把你目前為止的表現報告給那位大人......";}
    }
}