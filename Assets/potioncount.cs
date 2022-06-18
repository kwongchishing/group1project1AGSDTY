using UnityEngine;using UnityEngine.UI;public class potioncount:MonoBehaviour{
    public save2 save2;
    public Text countpotion;
    void Update(){countpotion.text=save2.currentpotion.ToString();}
}