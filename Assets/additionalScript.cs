using UnityEngine;public class additionalScript:MonoBehaviour{
    public save2 save2;
    public GameObject findgirl,FFfindgirl,FFprotecthouse,protecthouse,findsisterweapon,FFfindsisterweapon;
    void Update(){
        if(save2.sisterweapon<1){
            findsisterweapon.SetActive(true); FFfindsisterweapon.SetActive(false);
        }
        else{FFfindsisterweapon.SetActive(true);findsisterweapon.SetActive(false);}
        if(save2.defenseMaccept>0&&save2.defenseMfinish<1){
            protecthouse.SetActive(true);
        }
        if(save2.defenseMfinish>0){
            FFprotecthouse.SetActive(true);protecthouse.SetActive(false);
        }
        if(save2.findgirlMaccept>0&&save2.findgirlMfinish<1){
            findgirl.SetActive(true);
        }
        if(save2.findgirlMfinish>0){
            findgirl.SetActive(false);FFfindgirl.SetActive(true);
        }
    }
}