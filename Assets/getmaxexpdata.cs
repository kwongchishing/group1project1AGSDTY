using UnityEngine;using UnityEngine.UI;public class getmaxexpdata:MonoBehaviour{
    public save2 save2;
    public Ischange Ischange;
    public Exp Exp;
    public Text thistext;
    public WAXE_exp WAXE_exp;
    void Update(){
        if(Ischange.ischange<1){thistext.text=Exp.maxExp.ToString();}
        else{thistext.text=WAXE_exp.maxExp.ToString();}
        if(save2.finishgame>0){
            thistext.text=WAXE_exp.maxExp.ToString();
        }
    }
}