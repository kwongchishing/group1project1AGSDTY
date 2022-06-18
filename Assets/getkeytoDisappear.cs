using UnityEngine;using UnityEngine.UI;
public class getkeytoDisappear:MonoBehaviour{
    public int disappearcount;
    public sentenceFunction sentenceFunction;
    public Text words1space,words2space,words3space,words4space,words5space,NotallCorrectTxt;
    void Update(){
        if(Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            disappearcount++;            
        }
        if(disappearcount>=8){disappearcount=0;
            NotallCorrectTxt.text="";this.gameObject.SetActive(false);
        }
    }
}