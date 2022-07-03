using UnityEngine;using UnityEngine.UI;public class getchanattackdata:MonoBehaviour{
    public save2 save2;
    public Text thistext;
    public float addextraattack;
    void Update(){
        addextraattack=1+save2.chanextraattack;
        thistext.text=addextraattack.ToString();
    }
}