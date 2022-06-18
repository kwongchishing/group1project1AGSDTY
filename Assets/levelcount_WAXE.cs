using UnityEngine;using UnityEngine.UI;public class levelcount_WAXE:MonoBehaviour{
    public WAXE_exp exp;
    public Text countlevel;
    void Update(){
        countlevel.text=exp.level.ToString();
    }
}