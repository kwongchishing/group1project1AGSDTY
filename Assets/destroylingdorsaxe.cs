using UnityEngine;using UnityEngine.UI;public class destroylingdorsaxe:MonoBehaviour{
    public Text lingjortext;
    public float ling;
    void Start(){
        ling=float.Parse(lingjortext.text);
        ling+=1;
        lingjortext.text=ling.ToString();
        Destroy(this.gameObject,8);
    }
}