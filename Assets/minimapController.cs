using UnityEngine;public class minimapController:MonoBehaviour{
    public save2 save2;
    float distance5,distance4,distance3,distance,distance2;
    public GameObject chan,findgirlmission,NPC4, fire1,fire3,fire4,fire5,fire6,fire7,fire8,towergreenFX,sisterweaponminimapicon,NPC3,NPC2,Amissionminimapicon,defensehouseminimapicon,mmpointer,healskillUI,Player,seller,minimapcamera,minimap,NPC1;
    void Update(){
        distance=Vector3.Distance(Player.transform.position,seller.transform.position);
        distance2=Vector3.Distance(Player.transform.position,NPC1.transform.position);
        distance3=Vector3.Distance(Player.transform.position,NPC2.transform.position);
        distance4=Vector3.Distance(Player.transform.position,NPC3.transform.position);
        distance5=Vector3.Distance(Player.transform.position,NPC4.transform.position);
        if (save2.finishgame>0){mmpointer.SetActive(false);
            if(save2.isinshop){
                minimapcamera.SetActive(false);
                minimap.SetActive(false);                
            }
            if(save2.isjoined==true){
                minimapcamera.SetActive(false);
                minimap.SetActive(false);
                mmpointer.SetActive(false);
                healskillUI.SetActive(true);
            }
            if(save2.isjoined==false&&save2.isinshop==false){
                minimapcamera.SetActive(true);
                minimap.SetActive(true);
            }
            if(save2.isjoined==false&&save2.isinshop==true&&distance>20f&&distance2>30f&&distance3>30f&&distance4>20f&&distance5>20f){
                save2.isinshop=false;
            }
            if(save2.isjoined==false){               
                healskillUI.SetActive(false);
            }
        }
        if(save2.finishgame>0&&save2.sisterweapon<1){
            Amissionminimapicon.SetActive(true);
        }
        if(save2.sisterweapon>0&&save2.sisterweapon<20){
            Destroy(sisterweaponminimapicon);
            save2.sisterweapon=21;
        }
        if(save2.defenseMaccept>0&&save2.defenseMfinish<1){
            towergreenFX.SetActive(true);NPC3.GetComponent<SphereCollider>().enabled=false;
        }
        if(save2.defenseMfinish<1){
            defensehouseminimapicon.SetActive(true);
        }
        if(save2.defenseMfinish>0){
            Destroy(defensehouseminimapicon); NPC3.GetComponent<SphereCollider>().enabled=false;
        }
        if(save2.defenseMfail>0){
            fire1.SetActive(true);
            fire3.SetActive(true);
            fire4.SetActive(true);
            fire5.SetActive(true);
            fire6.SetActive(true);
            fire7.SetActive(true);
            fire8.SetActive(true);
        }
        if(save2.findgirlMaccept>0&&save2.findgirlMfinish<1){
            findgirlmission.SetActive(true);NPC4.GetComponent<SphereCollider>().enabled=false;
            chan.SetActive(false);
        }
        if(save2.findgirlMfinish>0){
            NPC4.GetComponent<SphereCollider>().enabled=false;
        }
    }
}