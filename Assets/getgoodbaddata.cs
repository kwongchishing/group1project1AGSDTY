using UnityEngine;using UnityEngine.UI;public class getgoodbaddata:MonoBehaviour{
    public save2 save2;
    float showgoodbad;
    public Text thistext;
    void Update(){
        showgoodbad=50-save2.goodbadcount;
            thistext.text=showgoodbad.ToString();
        }
    }