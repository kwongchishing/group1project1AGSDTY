using UnityEngine;using UnityEngine.UI;public class getcurrentexpdata:MonoBehaviour{
    public save2 save2;
    public Exp Exp;
    public Ischange Ischange;
    public Text thistext;
    public WAXE_exp WAXE_exp;
    void Update(){
        if(Ischange.ischange<1){thistext.text=Exp.currentExp.ToString();}
        else{thistext.text=WAXE_exp.currentExp.ToString();}
        if(save2.finishgame>0){
            thistext.text=WAXE_exp.currentExp.ToString();
        }
    }
}