using UnityEngine;using UnityEngine.UI;public class shitcount:MonoBehaviour{
    public save2 save2;
    public Text countshit;
    void Update(){countshit.text=save2.shitcount.ToString();}
}