using UnityEngine;using UnityEngine.UI;public class gettotalskillpointdata:MonoBehaviour{
    public save2 save2;
    public Text thistext;
    void Update(){
        thistext.text=save2.totalSkillPoint.ToString();
    }
}