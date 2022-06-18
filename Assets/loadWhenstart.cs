using UnityEngine;using UnityEngine.UI;public class loadWhenstart:MonoBehaviour{
    public Health hp;
    public Exp exp;
    public AudioSource bg1;
    public choosepickngpick potion;
    public Text mainmissionnow,Pname;
    public GameObject townwall2,townwall,tree,tree2,Bushes,OtherProps2,VillageFence2,OtherProps,VillageFence,mchousefake,mmpointer,punchUI,GoodBadCountBar,minimapiconmchouse,minimapiconthrowhouse,mainmissiontext,nobrokenaxeWALL,moneybag,player,startmission,howtoplay,icon,Playername,healthbar,expbar,starttext,potionCount,firstangrylog,potion1,potion2,potion3,canDestroy1,canDestroy2,canDestroy3,canDestroy4,canDestroy5,canDestroy6,canDestroy7,canDestroy8,canDestroy9,canDestroy10,canDestroy11,minimap,rubbishGROUP,sportFunction,frontwall,backwall,angrylog004,mchouse,Dodge;
    public Texture2D cursorArrow;public correctCount cc;
    public save2 save2;public Save save;public Text0_sport sc;
    void Start(){
            Cursor.SetCursor(cursorArrow,Vector2.zero,CursorMode.ForceSoftware); 
            exp.expcarrytonextlevel=0; save2.goodbadcount=50f;
        if(PlayerPrefs.HasKey("ActiveScene")){
            save.w_AXE=PlayerPrefs.GetFloat("w_AXE"); GoodBadCountBar.SetActive(true);
            if(save.w_AXE<1){
                mainmissiontext.SetActive(true);
                save2.goodbadcount=PlayerPrefs.GetFloat("goodbadcount");
                save2.totalSkillPoint=PlayerPrefs.GetInt("totalSkillPoint");
                save2.currentMoney=PlayerPrefs.GetInt("currentMoney");
                hp.currentHealth=PlayerPrefs.GetFloat("hp");
                hp.playerDefense=PlayerPrefs.GetFloat("defense");
                exp.playerAttack=PlayerPrefs.GetFloat("attack");
                //getMaxexpThenExploadmax¥ý
                exp.maxExp=PlayerPrefs.GetFloat("maxexp");
                exp.currentExp=PlayerPrefs.GetFloat("exp");
                exp.level=PlayerPrefs.GetFloat("level");
                save2.currentpotion=PlayerPrefs.GetFloat("potion");
                save2.potion1des=PlayerPrefs.GetFloat("potion1des");
                if(save2.potion1des>0){Destroy(potion1);}
                save2.potion2des=PlayerPrefs.GetFloat("potion2des");
                if(save2.potion2des>0){Destroy(potion2);}
                save2.potion3des=PlayerPrefs.GetFloat("potion3des");
                if(save2.potion3des>0){Destroy(potion3);}
                Pname.text=PlayerPrefs.GetString("name");
                save.getbrokenaxe=PlayerPrefs.GetFloat("getbrokenaxe");
                if(save.getbrokenaxe>0){Destroy(firstangrylog);}
                //throw
                sc.cancelCount=PlayerPrefs.GetFloat("cancelCount");
                save.iron=PlayerPrefs.GetFloat("iron");
                save.playedbutnotwin=PlayerPrefs.GetFloat("playedbutnotwin");
                if(save.iron==1){
                    Destroy(rubbishGROUP);
                    Destroy(sportFunction);
                    Destroy(frontwall);
                    Destroy(backwall);
                }
                save.angryloginhousedie=PlayerPrefs.GetFloat("angryloginhousedie");
                if(save.angryloginhousedie>0){Destroy(angrylog004);}
                save.getDodge=PlayerPrefs.GetFloat("getDodge");                             
                mainmissionnow.text=PlayerPrefs.GetString("mainmissionnow");
                save.finishMaths=PlayerPrefs.GetFloat("finishMaths");
                if(save.finishMaths<1){mmpointer.transform.LookAt(new Vector3(mchousefake.transform.position.x,mchousefake.transform.position.y,mchousefake.transform.position.z));}
                if(save.finishMaths>0){
                    Destroy(canDestroy1);
                    Destroy(canDestroy2);
                    Destroy(canDestroy3);
                    Destroy(canDestroy4);
                    Destroy(canDestroy5);
                    Destroy(canDestroy6);
                    Destroy(canDestroy7);
                    Destroy(canDestroy8);
                    Destroy(canDestroy9);
                    Destroy(canDestroy10);
                    Destroy(canDestroy11);
                    minimapiconmchouse.SetActive(false);
                    minimapiconthrowhouse.SetActive(true);
                }
                if(save.getDodge>0){
                    Dodge.SetActive(true); minimapiconthrowhouse.SetActive(false); minimapiconmchouse.SetActive(true);
                }   
                cc.retryOrnot=PlayerPrefs.GetFloat("retryOrnot");
                cc.firstTimeandNotready=PlayerPrefs.GetFloat("firstTimeandNotready");
                player.transform.position=new Vector3(PlayerPrefs.GetFloat("PlayerX"),PlayerPrefs.GetFloat("PlayerY"),PlayerPrefs.GetFloat("PlayerZ"));
                player.transform.rotation=Quaternion.Euler(PlayerPrefs.GetFloat("RotationX"),PlayerPrefs.GetFloat("RotationY"),PlayerPrefs.GetFloat("RotationZ"));
                Destroy(startmission);
                Destroy(howtoplay);
                icon.SetActive(true);
                Playername.SetActive(true);
                healthbar.SetActive(true);
                expbar.SetActive(true);
                Destroy(starttext);
                potionCount.SetActive(true);
                punchUI.SetActive(true);
                moneybag.SetActive(true);
            }            
            else{
                Destroy(this.gameObject);
            }
            }
        //mc fail
        if(PlayerPrefs.HasKey("mcPlayerX")){
            mainmissiontext.SetActive(true);
            save2.totalSkillPoint=PlayerPrefs.GetInt("mctotalSkillPoint");
            save2.goodbadcount=PlayerPrefs.GetFloat("mcgoodbadcount");
            save2.currentMoney=PlayerPrefs.GetInt("mccurrentMoney");
            hp.currentHealth=PlayerPrefs.GetFloat("mchp");
            hp.playerDefense=PlayerPrefs.GetFloat("mcdefense");
            exp.playerAttack=PlayerPrefs.GetFloat("mcattack");
            exp.maxExp=PlayerPrefs.GetFloat("mcmaxexp");
            exp.currentExp=PlayerPrefs.GetFloat("mcexp");
            exp.level=PlayerPrefs.GetFloat("mclevel");
            save2.currentpotion=PlayerPrefs.GetFloat("mcpotion");
            save2.potion1des=PlayerPrefs.GetFloat("mcpotion1des");
            if(save2.potion1des>0){Destroy(potion1);}
            save2.potion2des=PlayerPrefs.GetFloat("mcpotion2des");
            if(save2.potion2des>0){Destroy(potion2);}
            save2.potion3des=PlayerPrefs.GetFloat("mcpotion3des");
            if(save2.potion3des>0){Destroy(potion3);}
            Pname.text=PlayerPrefs.GetString("mcname");
            Destroy(firstangrylog);
            mainmissionnow.text=PlayerPrefs.GetString("mcmainmissionnow");
            cc.retryOrnot=PlayerPrefs.GetFloat("mcretryOrnot");
            cc.firstTimeandNotready=PlayerPrefs.GetFloat("mcfirstTimeandNotready"); mchouse.SetActive(true); save.getbrokenaxe=PlayerPrefs.GetFloat("mcgetbrokenaxe");
            player.transform.position=new Vector3(PlayerPrefs.GetFloat("mcPlayerX"),PlayerPrefs.GetFloat("mcPlayerY"),PlayerPrefs.GetFloat("mcPlayerZ"));
            player.transform.rotation=Quaternion.Euler(PlayerPrefs.GetFloat("mcRotationX"),PlayerPrefs.GetFloat("mcRotationY"),PlayerPrefs.GetFloat("mcRotationZ"));
            mmpointer.SetActive(false);            
            Destroy(startmission);
            Destroy(howtoplay);
            icon.SetActive(true);
            Playername.SetActive(true);
            healthbar.SetActive(true);
            GoodBadCountBar.SetActive(true);
            minimap.SetActive(false);
            expbar.SetActive(true);
            Destroy(starttext);
            potionCount.SetActive(true);
            punchUI.SetActive(true);
            Destroy(nobrokenaxeWALL);
            moneybag.SetActive(true); PlayerPrefs.DeleteKey("mcPlayerX");bg1.Stop();
        }
        if(save2.finishgame<1){
            VillageFence.SetActive(true);
            Destroy(VillageFence2);
            OtherProps.SetActive(true);
            Destroy(OtherProps2);
            tree.SetActive(true);
            Destroy(tree2);
            Bushes.SetActive(true);
            Destroy(townwall2);
            townwall.SetActive(true);
        }
        //
    }
}