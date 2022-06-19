using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class save2:MonoBehaviour{
    public wAXE_health hp;
    public WAXE_exp exp;
    public Text mainmissionnow;
    public int activeScene;
    public Text Pname;
    public GameObject player;
    public Ischange changeornot;
    public float shitcount,petStart,findgirlMfinish,findgirlMaccept,defenseMfail,defenseMfinish,defenseMaccept,bull_kingisdead3,bull_kingisdead2,bull_kingisdead1,bull_kingisdead,mainmission1finish,sisterweapon,newgamesaved;   //newgame2
    public float finishgame,gateopened,finishsentence,cageIsdestroy,collectedkey,currentpotion,goodbadcount,letterOstone,letterPstone,finishOstone,finishBombgame, finishPstone,trapisstep,mission3finish,clearwell2,clearwell3,clearwell4,talkedwithsister;
    public SaveDataBeforeDestroy SDBD;
    public int currentMoney,totalSkillPoint,point1finish,point2finish,point3finish,point4finish,point5finish,point6finish,point7finish;
    //for potion collected
    public float potion1des,potion2des,potion3des;
    public bool isjoined,isinshop;
    //use for display  text only
    public GameObject saved;
    public float w_AXE;
    void Start(){
        w_AXE=1;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E))
        {  //press enter save        
            //savehp
            PlayerPrefs.SetFloat("hp",hp.currentHealth);
            //save player defense and attack
            PlayerPrefs.SetFloat("defense",hp.playerDefense);
            PlayerPrefs.SetFloat("attack",exp.playerAttack);
            //goodbadcount
            PlayerPrefs.SetFloat("goodbadcount",goodbadcount);
            //expwithmaxexp
            PlayerPrefs.SetFloat("exp",exp.currentExp);
            PlayerPrefs.SetFloat("maxexp",exp.maxExp);
            //levelwithdisplay
            PlayerPrefs.SetFloat("level",exp.level);
            //potion with display and destroy
            PlayerPrefs.SetFloat("potion",currentpotion);
            PlayerPrefs.SetFloat("potion1des",potion1des);
            PlayerPrefs.SetFloat("potion2des",potion2des);
            PlayerPrefs.SetFloat("potion3des",potion3des);
            //scene
            activeScene=SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("ActiveScene",activeScene);
            //name
            PlayerPrefs.SetString("name",Pname.text);
            //money
            PlayerPrefs.SetInt("currentMoney",currentMoney);
            //player save position
            PlayerPrefs.SetFloat("PlayerX",player.transform.position.x);
            PlayerPrefs.SetFloat("PlayerY",player.transform.position.y);
            PlayerPrefs.SetFloat("PlayerZ",player.transform.position.z);
            PlayerPrefs.SetFloat("RotationX",player.transform.eulerAngles.x);
            PlayerPrefs.SetFloat("RotationY",player.transform.eulerAngles.y);
            PlayerPrefs.SetFloat("RotationZ",player.transform.eulerAngles.z);
            PlayerPrefs.SetFloat("w_AXE",w_AXE);
            //savecurrentmainmission topleft
            PlayerPrefs.SetString("mainmissionnow",mainmissionnow.text);
            //changeCHARATERORNOT
            PlayerPrefs.SetFloat("ischange",changeornot.ischange);
            //savesound only not savedata
            GetComponent<AudioSource>().Play();
            saved.SetActive(true);
            //save key and keycage mission2
            PlayerPrefs.SetFloat("cageIsdestroy",cageIsdestroy);
            PlayerPrefs.SetFloat("collectedkey",collectedkey);
            PlayerPrefs.SetFloat("gateopened",gateopened);
            //OstoneandPstone
            PlayerPrefs.SetFloat("finishBombgame",finishBombgame);
            PlayerPrefs.SetFloat("letterOstone",letterOstone);
            PlayerPrefs.SetFloat("letterPstone",letterPstone);
            PlayerPrefs.SetFloat("finishOstone",finishOstone);
            PlayerPrefs.SetFloat("finishPstone",finishPstone);
            PlayerPrefs.SetFloat("trapisstep",trapisstep);
            PlayerPrefs.SetFloat("mission3finish",mission3finish);
            //UGTunnel
            PlayerPrefs.SetFloat("clearwell2",clearwell2);
            PlayerPrefs.SetFloat("clearwell3",clearwell3);
            PlayerPrefs.SetFloat("clearwell4",clearwell4);
            //prison
            PlayerPrefs.SetFloat("talkedwithsister",talkedwithsister);
            PlayerPrefs.SetFloat("finishsentence",finishsentence);
            //save totalskillpoint
            PlayerPrefs.SetInt("totalSkillPoint",totalSkillPoint);
            PlayerPrefs.SetInt("point1finish",point1finish);
            PlayerPrefs.SetFloat("finishgame",finishgame);
            //load when save
            SceneManager.LoadScene(activeScene);
        }
        else{saved.SetActive(false);
        }
    }
}