using UnityEngine;public class chantungtungJoin:MonoBehaviour{
    public save2 save2;
    public GameObject miniicon,talktungtung, chantungtung,findgirlmission,All_colliderwall;
    void Start(){
        Destroy(All_colliderwall);
        chantungtung.SetActive(true);
        Destroy(talktungtung);
        save2.findgirlMfinish++;
        Destroy(miniicon);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            Destroy(findgirlmission);
        }
    }
}