using UnityEngine;using UnityEngine.UI;public class levelcount:MonoBehaviour{
    public Exp exp;
    public Text countlevel;
    void Update(){
        countlevel.text=exp.level.ToString();
    }
}