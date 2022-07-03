using UnityEngine;using UnityEngine.UI;public class getsisterattackdata:MonoBehaviour{
    public save2 save2;
    public Text thistext;
    public float addextraattack;
    void Update(){
        if(save2.sisterweapon<1){
            thistext.text="3";
        }
        if(save2.sisterweapon>0){
            addextraattack=10+save2.sisterextraattack;
            thistext.text=addextraattack.ToString();
        }
    }
}