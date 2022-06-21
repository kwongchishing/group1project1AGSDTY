using UnityEngine;using UnityEngine.UI;public class wAXEloadGame:MonoBehaviour{
    public wAXE_health hp;
    public WAXE_exp exp;
    public Text mainmissionnow,Pname;
    public GameObject realpet2,fakepethouse, realpethouse,talkcanvaspet,petleavecanvas,NPCpet,fakepet,realpet,chan,Real_houes4,potionHouse2,House1,House2,House3,fakedefenseMissionhouse,swordinwaitsisterhand,swordinp2hand,sisterweaponNPC,talkgetweaponCanvas,housesmokeFX,townwall,townwall2,All_newgame2notes,new2gamecollider,newgame2startPanel,myhousefake,Amission1house,mainmission1house1,bmainmission1house1,Ostoneminiicon,Pstoneminiicon,secretpathminiicon,missionbook,All_BULL_Enemy,All_BULL_Enemy2,icon2,playerInfoPanel,Lanters,newmainmission1,sisterwaitforjoin,Bushes,VillageFence,VillageFence2, OtherProps,OtherProps2,tree,tree2,undergroundFinalboss,undergroundFinalboss2,real_Pstonehouse,real_Ostonehouse,StonePuzzleCanvas,LetterOSTONE,GetOStone,undergroud,bgm1Collider,bgm3Collider,All_guard,finishgameCanvas,Allshieldman,newbgm1,Allnotes,mmpointer,Pstonehousearrow,buttoncollider,electricUI,talkwithsistercollider,well2Stone,well3Stone,well4Stone,mission3house,mission3housefinished,Pstoneminimapicon,trap1,trap2,trap3,trap4,Btrap1,Btrap2,saw1,saw2,saw3,saw4,saw5,saw6,saw7,axe1,axe2,axe3,hammer1,hammer2,All_powerfulGuard,PstonePlace,Pstonefinish,Pstone,groupbarrel,Ostoneminimapicon,All_turtle,whereOstone,NotbombBarrel,OstonePlace,Ostonefinish,bg4,AlloldmanEnemy,Ostone,GoodBadCountBar,SDBDfile,minimapiconKey,mainmissiontext,oldplayer,player,startmission,howtoplay,Playername,healthbar,expbar,starttext,axeUI,potionCount,punchUI,firstangrylog,potion1,potion2,potion3,icon,sportFunction,MathFunction,saveNPC1,saveNPC2,moneybag,cage,notes8,angry2,angry3,angry5,humanenemy,oldmusic,brokenaxechecker1,humanenemy2,GateKey,gateL,gateR,gateCollider,boss1,unrealboss1,runningGame,saveNPCforkillboss1,brokenaxechecker2,minimapiconmchouse,minimapiconGate;
public AudioSource main2music;public Texture2D cursorArrow;public Ischange changeornot;public save2 save;
    void Start(){
        if(PlayerPrefs.HasKey("Volume")){
            AudioListener.volume=PlayerPrefs.GetFloat("Volume");
        }
            changeornot.ischange=PlayerPrefs.GetFloat("ischange"); 
        save.w_AXE=PlayerPrefs.GetFloat("w_AXE");
        save.collectedkey=PlayerPrefs.GetFloat("collectedkey");
        if(PlayerPrefs.HasKey("finishgame")){
            save.finishgame=PlayerPrefs.GetFloat("finishgame");}
            Cursor.SetCursor(cursorArrow,Vector2.zero,CursorMode.ForceSoftware);
           exp.expcarrytonextlevel=0;
        // get axe not fight boss ------------------------------------------------------->>>>>>>>>>>>>
            if(save.w_AXE>0&&save.collectedkey<1&&save.finishgame<1){
            player.SetActive(true);
            GoodBadCountBar.SetActive(true);
            Destroy(oldplayer);
            notes8.SetActive(true);
            Destroy(saveNPC1);
            saveNPC2.SetActive(true);
            Destroy(angry2);
            Destroy(angry3);
            Destroy(angry5);
            humanenemy.SetActive(true);
            oldmusic.SetActive(false);
            main2music.Play();
            mainmissiontext.SetActive(true);
            Destroy(brokenaxechecker1);
            Destroy(brokenaxechecker2);minimapiconmchouse.SetActive(false);minimapiconGate.SetActive(true);
            hp.currentHealth=PlayerPrefs.GetFloat("hp");
                hp.playerDefense=PlayerPrefs.GetFloat("defense");
                exp.playerAttack=PlayerPrefs.GetFloat("attack");
            save.goodbadcount=PlayerPrefs.GetFloat("goodbadcount");
            //getMaxexpThenExp
            exp.maxExp=PlayerPrefs.GetFloat("maxexp");
                exp.currentExp=PlayerPrefs.GetFloat("exp");
                exp.level=PlayerPrefs.GetFloat("level");
                save.currentpotion=PlayerPrefs.GetFloat("potion");
                save.potion1des=PlayerPrefs.GetFloat("potion1des");
                if (save.potion1des>0) {Destroy(potion1);}
                save.potion2des=PlayerPrefs.GetFloat("potion2des");
                if (save.potion2des>0) {Destroy(potion2);}
                save.potion3des=PlayerPrefs.GetFloat("potion3des");
                if(save.potion3des>0){Destroy(potion3);}
                Pname.text=PlayerPrefs.GetString("name");
            save.currentMoney=PlayerPrefs.GetInt("currentMoney");
            //mission2 key cage destroy or not
            save.cageIsdestroy=PlayerPrefs.GetFloat("cageIsdestroy");
            if(save.cageIsdestroy>0){Destroy(cage);}
            save.totalSkillPoint=PlayerPrefs.GetInt("totalSkillPoint");
            Destroy(firstangrylog);
            Destroy(sportFunction);
            Destroy(MathFunction);
                mainmissionnow.text=PlayerPrefs.GetString("mainmissionnow");
                player.transform.position=new Vector3(PlayerPrefs.GetFloat("PlayerX"),PlayerPrefs.GetFloat("PlayerY"),PlayerPrefs.GetFloat("PlayerZ"));
            player.transform.rotation=Quaternion.Euler(PlayerPrefs.GetFloat("RotationX"),PlayerPrefs.GetFloat("RotationY"),PlayerPrefs.GetFloat("RotationZ"));
            //display and destroy at start
            Destroy(startmission);
                Destroy(howtoplay);
                icon.SetActive(true);
                Playername.SetActive(true);
                healthbar.SetActive(true);
                expbar.SetActive(true);
                Destroy(starttext);
                potionCount.SetActive(true);
            Destroy(punchUI);
            axeUI.SetActive(true);
            moneybag.SetActive(true);
            VillageFence.SetActive(true);
            Destroy(VillageFence2);
            OtherProps.SetActive(true);
            Destroy(OtherProps2);
            Destroy(townwall2);
            townwall.SetActive(true);
            tree.SetActive(true);
            Destroy(tree2);
            Bushes.SetActive(true);
            }
            //if collectKeyandopengate           ----------------2222222222-------------------->>>>>>>>>>>
        if(save.w_AXE>0&&save.collectedkey>0&&save.finishgame<1){
            player.SetActive(true); GoodBadCountBar.SetActive(true);
            Destroy(oldplayer);
            notes8.SetActive(true);
            Destroy(saveNPC1);
            saveNPC2.SetActive(true);
            saveNPC2.transform.position=new Vector3(395.235107f,29.3612156f,315.978302f);
            Destroy(angry2);
            Destroy(angry3);
            Destroy(angry5);
            humanenemy2.SetActive(true);
            oldmusic.SetActive(true);
            mainmissiontext.SetActive(true);
            Destroy(brokenaxechecker1);
            Destroy(brokenaxechecker2);
            hp.currentHealth=PlayerPrefs.GetFloat("hp");
            hp.playerDefense=PlayerPrefs.GetFloat("defense");
            exp.playerAttack=PlayerPrefs.GetFloat("attack");
            save.goodbadcount = PlayerPrefs.GetFloat("goodbadcount");
            //getMaxexpThenExp
            save.totalSkillPoint = PlayerPrefs.GetInt("totalSkillPoint");
            exp.maxExp=PlayerPrefs.GetFloat("maxexp");
            exp.currentExp=PlayerPrefs.GetFloat("exp");
            exp.level=PlayerPrefs.GetFloat("level");
            save.currentpotion=PlayerPrefs.GetFloat("potion");
            save.potion1des=PlayerPrefs.GetFloat("potion1des");
            if(save.potion1des>0){Destroy(potion1);}
            save.potion2des=PlayerPrefs.GetFloat("potion2des");
            if(save.potion2des>0){Destroy(potion2);}
            save.potion3des=PlayerPrefs.GetFloat("potion3des");
            if(save.potion3des>0){Destroy(potion3);}
            Pname.text=PlayerPrefs.GetString("name");
            save.currentMoney=PlayerPrefs.GetInt("currentMoney");
            save.finishBombgame=PlayerPrefs.GetFloat("finishBombgame");
            save.letterOstone=PlayerPrefs.GetFloat("letterOstone");
            save.letterPstone=PlayerPrefs.GetFloat("letterPstone");
            save.finishOstone=PlayerPrefs.GetFloat("finishOstone");
            save.finishPstone=PlayerPrefs.GetFloat("finishPstone");
            save.trapisstep=PlayerPrefs.GetFloat("trapisstep");
            if(save.trapisstep>0){
                trap1.GetComponent<Animation>().enabled=true;
                trap2.GetComponent<Animation>().enabled=true;
                trap3.GetComponent<Animation>().enabled=true;
                trap4.GetComponent<Animation>().enabled=true;
                Btrap1.GetComponent<Animation>().enabled=true;
                Btrap2.GetComponent<Animation>().enabled=true;
                saw1.GetComponent<Animation>().enabled=true;
                saw2.GetComponent<Animation>().enabled=true;
                saw3.GetComponent<Animation>().enabled=true;
                saw4.GetComponent<Animation>().enabled=true;
                saw5.GetComponent<Animation>().enabled=true;
                saw6.GetComponent<Animation>().enabled=true;
                saw7.GetComponent<Animation>().enabled=true;
                axe1.GetComponent<Animation>().enabled=true;
                axe2.GetComponent<Animation>().enabled=true;
                axe3.GetComponent<Animation>().enabled=true;
                hammer1.GetComponent<Animation>().enabled=true;
                hammer2.GetComponent<Animation>().enabled=true;}
            save.mission3finish=PlayerPrefs.GetFloat("mission3finish");
            if(save.mission3finish>0){
                Destroy(mission3house);
                mission3housefinished.SetActive(true);mainmissionnow.text="主線任務四：救出妹妹！";
            }
            //ug destroy
            Destroy(cage);
            Destroy(GateKey);
             Destroy(firstangrylog);
            Destroy(sportFunction);
            Destroy(MathFunction);
            //gateopen
            save.gateopened=PlayerPrefs.GetFloat("gateopened");
            gateR.transform.rotation=Quaternion.Euler(0,215.061752f,0);
            gateL.transform.rotation=Quaternion.Euler(0,148.844162f,0);
            if(save.gateopened>0&&save.finishPstone<1) Pstonehousearrow.SetActive(true);
            if(save.finishPstone>0) Destroy(Pstonehousearrow);
            if(save.finishOstone>0&&save.finishPstone<1) mmpointer.SetActive(false);
            Destroy(gateCollider);
            Destroy(unrealboss1);
            Destroy(boss1);
            Destroy(runningGame);
            Destroy(saveNPCforkillboss1);
            if(save.mission3finish<1){mainmissionnow.text="主線任務三：找出隱藏在村子裡的秘道！";}
            player.transform.position=new Vector3(PlayerPrefs.GetFloat("PlayerX"),PlayerPrefs.GetFloat("PlayerY"),PlayerPrefs.GetFloat("PlayerZ"));
            player.transform.rotation=Quaternion.Euler(PlayerPrefs.GetFloat("RotationX"),PlayerPrefs.GetFloat("RotationY"),PlayerPrefs.GetFloat("RotationZ"));
            if(save.finishBombgame>0){
                Destroy(groupbarrel);whereOstone.SetActive(true);Destroy(NotbombBarrel); Destroy(Ostoneminimapicon); Ostone.SetActive(true);
            }
            if(save.letterOstone>0){
                Destroy(Ostone);AlloldmanEnemy.SetActive(true);bg4.SetActive(true); oldmusic.SetActive(false);
            }
            if(save.finishOstone>0){
                Destroy(OstonePlace);Ostonefinish.SetActive(true);
            }
            if(save.letterPstone>0){
                Destroy(Pstone); bg4.SetActive(true); oldmusic.SetActive(false); All_powerfulGuard.SetActive(true); Destroy(Pstoneminimapicon);
            }
            if(save.finishPstone>0){
                Destroy(PstonePlace);Pstonefinish.SetActive(true);
            }
            save.clearwell2=PlayerPrefs.GetFloat("clearwell2");
            if(save.clearwell2>0){
                Destroy(well2Stone);}
            save.clearwell3=PlayerPrefs.GetFloat("clearwell3");
            if(save.clearwell3>0){
                Destroy(well3Stone);}
            save.clearwell4=PlayerPrefs.GetFloat("clearwell4");
            if(save.clearwell4>0){
                Destroy(well4Stone);}
            save.talkedwithsister=PlayerPrefs.GetFloat("talkedwithsister");
            if(save.talkedwithsister>0){
                Destroy(talkwithsistercollider);
            }
            save.finishsentence=PlayerPrefs.GetFloat("finishsentence");
            if (save.finishsentence>0){
                electricUI.SetActive(true);
                Destroy(buttoncollider);
            }
            //display and destroy at start
            Destroy(startmission);
            Destroy(howtoplay);
            icon.SetActive(true);
            Playername.SetActive(true);
            healthbar.SetActive(true);
            expbar.SetActive(true);
            Destroy(starttext);
            potionCount.SetActive(true);
            Destroy(punchUI);
            axeUI.SetActive(true);
            moneybag.SetActive(true); minimapiconGate.SetActive(false); minimapiconKey.SetActive(false); minimapiconmchouse.SetActive(false);
            Destroy(SDBDfile);
            All_turtle.SetActive(true);
            VillageFence.SetActive(true);
            Destroy(VillageFence2);
            Destroy(townwall2);
            townwall.SetActive(true);
            OtherProps.SetActive(true);
            Destroy(OtherProps2);
            tree.SetActive(true);
            Destroy(tree2);
            Bushes.SetActive(true);
        }
        //------------------------------------------------------3333333333333333
        if(save.finishgame>0){
            Destroy(SDBDfile);
            save.newgamesaved = PlayerPrefs.GetFloat("newgamesaved");
            All_newgame2notes.SetActive(true);
            missionbook.SetActive(true);Destroy(oldplayer);
            newbgm1.SetActive(true);
            Destroy(housesmokeFX);
            mmpointer.SetActive(false);
            hp.currentHealth=PlayerPrefs.GetFloat("hp");
            if(save.newgamesaved<1){
                 player.transform.position=new Vector3(417.292511f,30.2289944f,291.310608f);
                newgame2startPanel.SetActive(true);hp.currentHealth=100;
            }
            hp.playerDefense=PlayerPrefs.GetFloat("defense");
            exp.playerAttack=PlayerPrefs.GetFloat("attack");
            exp.level=PlayerPrefs.GetFloat("level");
            exp.maxExp=PlayerPrefs.GetFloat("maxexp");
            exp.currentExp=PlayerPrefs.GetFloat("exp");
            save.currentpotion=PlayerPrefs.GetFloat("potion");
            Pname.text=PlayerPrefs.GetString("name");
            save.currentMoney=PlayerPrefs.GetInt("currentMoney");
            Destroy(saveNPC1);
            save.totalSkillPoint=PlayerPrefs.GetInt("totalSkillPoint");
            save.point1finish = PlayerPrefs.GetInt("point1finish");
            save.point2finish = PlayerPrefs.GetInt("point2finish");
            save.point3finish = PlayerPrefs.GetInt("point3finish");
            save.point4finish = PlayerPrefs.GetInt("point4finish");
            save.point5finish = PlayerPrefs.GetInt("point5finish");
            save.point6finish = PlayerPrefs.GetInt("point6finish");
            save.point7finish = PlayerPrefs.GetInt("point7finish");
            saveNPC2.SetActive(false);player.SetActive(true);
            //display and destroy at start
            realpethouse.SetActive(true);
            Real_houes4.SetActive(true);
            potionHouse2.SetActive(true);
            House1.SetActive(true);
            House2.SetActive(true);
            House3.SetActive(true);
            Destroy(startmission);
            Destroy(howtoplay);
            Playername.SetActive(true);
            healthbar.SetActive(true);
            expbar.SetActive(true);
            Destroy(starttext);
            potionCount.SetActive(true);
            Destroy(punchUI);
            axeUI.SetActive(true);
            moneybag.SetActive(true);            
            Destroy(startmission);
            Destroy(howtoplay);            
            Destroy(minimapiconGate);
            Destroy(minimapiconKey);
            Destroy(minimapiconmchouse);
            Destroy(starttext);
            Destroy(potion1);
            Destroy(potion2);
            Destroy(potion3);
            Destroy(angry2);
            Destroy(angry3);
            Destroy(angry5);
            Destroy(mission3house);
            mission3housefinished.SetActive(true);
            Destroy(brokenaxechecker1);
            Destroy(brokenaxechecker2);
            Destroy(humanenemy2);
            Destroy(humanenemy);
            oldmusic.SetActive(false);
            Destroy(firstangrylog);
            Destroy(sportFunction);
            Destroy(MathFunction);
            Destroy(Allnotes);
            Destroy(Allshieldman);
            Destroy(AlloldmanEnemy);
            Destroy(finishgameCanvas);
            Destroy(All_powerfulGuard);
            Destroy(All_guard);
            Destroy(townwall);
            townwall2.SetActive(true);
            gateR.transform.rotation=Quaternion.Euler(0,215.061752f,0);
            gateL.transform.rotation=Quaternion.Euler(0,148.844162f,0);
            Destroy(gateCollider);
            Destroy(bgm3Collider);
            Destroy(bgm1Collider);
            Destroy(undergroud);
            Destroy(runningGame);
            Destroy(boss1);
            Destroy(unrealboss1);
            Destroy(saveNPCforkillboss1);
            Destroy(GetOStone);
            Destroy(LetterOSTONE);
            Destroy(StonePuzzleCanvas);
            Destroy(real_Pstonehouse);
            Destroy(real_Ostonehouse);
            Destroy(mission3house);
            Destroy(undergroundFinalboss);
            undergroundFinalboss2.SetActive(true);
            Destroy(tree);
            tree2.SetActive(true);
            Destroy(OtherProps);
            OtherProps2.SetActive(true);
            Destroy(VillageFence);
            VillageFence2.SetActive(true);
            Destroy(Bushes);
            sisterwaitforjoin.SetActive(true);
            newmainmission1.SetActive(true);
            Destroy(Lanters);
            save.finishsentence++;
            electricUI.SetActive(true);
            electricUI.GetComponent<RectTransform>().anchoredPosition=new Vector3(54,0,0);
            electricUI.GetComponent<RectTransform>().anchorMin=new Vector2(0,0.5f);
            electricUI.GetComponent<RectTransform>().anchorMax=new Vector2(0,0.5f);
            electricUI.GetComponent<RectTransform>().pivot=new Vector2(0,0.5f);
            Destroy(playerInfoPanel);
            Destroy(icon);
            icon2.SetActive(true);
            All_BULL_Enemy2.SetActive(true);
            Destroy(All_BULL_Enemy);
            Destroy(Ostoneminiicon);
            Destroy(Pstoneminiicon);
            Destroy(secretpathminiicon);
            Destroy(mainmission1house1);
            bmainmission1house1.SetActive(true);
            Amission1house.GetComponent<SphereCollider>().enabled=true;
            myhousefake.GetComponent<SphereCollider>().enabled=true;
            fakedefenseMissionhouse.GetComponent<SphereCollider>().enabled=true;
            fakepethouse.GetComponent<SphereCollider>().enabled=true;
            new2gamecollider.SetActive(true);
            save.bull_kingisdead=PlayerPrefs.GetFloat("bull_kingisdead");
            save.bull_kingisdead1=PlayerPrefs.GetFloat("bull_kingisdead1");
            save.bull_kingisdead2=PlayerPrefs.GetFloat("bull_kingisdead2");
            save.bull_kingisdead3=PlayerPrefs.GetFloat("bull_kingisdead3");
            save.sisterweapon=PlayerPrefs.GetFloat("sisterweapon");
            if(save.sisterweapon>0){
                swordinwaitsisterhand.SetActive(true);
                swordinp2hand.SetActive(true);
                sisterweaponNPC.GetComponent<SphereCollider>().enabled=false;
                Destroy(talkgetweaponCanvas);
            }
            save.defenseMaccept=PlayerPrefs.GetFloat("defenseMaccept");
            save.defenseMfinish=PlayerPrefs.GetFloat("defenseMfinish");
            save.defenseMfail=PlayerPrefs.GetFloat("defenseMfail");
            save.mainmission1finish=PlayerPrefs.GetFloat("mainmission1finish");
            save.findgirlMaccept=PlayerPrefs.GetFloat("findgirlMaccept");
            save.findgirlMfinish=PlayerPrefs.GetFloat("findgirlMfinish");
            save.petStart=PlayerPrefs.GetFloat("petStart");
            save.shitcount=PlayerPrefs.GetFloat("shitcount");
            if(save.petStart==1){
                Destroy(fakepet);
                realpet.SetActive(true);
                NPCpet.GetComponent<SphereCollider>().enabled=false;
                petleavecanvas.SetActive(true);
                Destroy(talkcanvaspet);
            }
            if(save.petStart==2){
                Destroy(fakepet);
                Destroy(realpet);
                realpet2.SetActive(true);
                NPCpet.GetComponent<SphereCollider>().enabled=false;
                petleavecanvas.SetActive(true);
                Destroy(talkcanvaspet);
            }
            if (save.newgamesaved==1){
                player.transform.position=new Vector3(978.670227f,-117.409554f,-113.36776f);
                save.isinshop=true;
            }
            if(save.findgirlMfinish>0){
                chan.SetActive(true);
            }
        }
    }    
}