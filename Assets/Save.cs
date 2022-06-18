using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class Save:MonoBehaviour{
    public Health hp;
    public Exp exp;
    public Text Pname,mainmissionnow;
    public int activeScene;
    public GameObject player,saved;
    public correctCount cc;
    //save Sport game
    public Text0_sport sc;
    public float finishMaths,getbrokenaxe,gethitbyRubbish,iron,playedbutnotwin,angryloginhousedie,w_AXE,getDodge;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {            
            //p info
            PlayerPrefs.SetFloat("hp",hp.currentHealth);
            PlayerPrefs.SetFloat("defense",hp.playerDefense);
            PlayerPrefs.SetFloat("goodbadcount",save2.goodbadcount);
            PlayerPrefs.SetFloat("attack",exp.playerAttack);
            PlayerPrefs.SetFloat("exp",exp.currentExp);
            PlayerPrefs.SetFloat("maxexp",exp.maxExp);
            PlayerPrefs.SetFloat("level",exp.level);
            PlayerPrefs.SetString("name",Pname.text);
            //money
            PlayerPrefs.SetInt("currentMoney",save2.currentMoney);
            //potion
            PlayerPrefs.SetFloat("potion",save2.currentpotion);
            PlayerPrefs.SetFloat("potion1des",save2.potion1des);
            PlayerPrefs.SetFloat("potion2des",save2.potion2des);
            PlayerPrefs.SetFloat("potion3des",save2.potion3des);
            //sc
            activeScene=SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("ActiveScene",activeScene);
            //player po ro
            PlayerPrefs.SetFloat("PlayerX",player.transform.position.x);
            PlayerPrefs.SetFloat("PlayerY",player.transform.position.y);
            PlayerPrefs.SetFloat("PlayerZ",player.transform.position.z);
            PlayerPrefs.SetFloat("RotationX",player.transform.eulerAngles.x);
            PlayerPrefs.SetFloat("RotationY",player.transform.eulerAngles.y);
            PlayerPrefs.SetFloat("RotationZ",player.transform.eulerAngles.z);
            //broken axe
            PlayerPrefs.SetFloat("getbrokenaxe",getbrokenaxe);
            //Maths
            PlayerPrefs.SetFloat("finishMaths",finishMaths);
            PlayerPrefs.SetFloat("retryOrnot",cc.retryOrnot);
            PlayerPrefs.SetFloat("firstTimeandNotready",cc.firstTimeandNotready);
            //throw
            PlayerPrefs.SetFloat("cancelCount",sc.cancelCount);
            PlayerPrefs.SetFloat("iron",iron);
            PlayerPrefs.SetFloat("playedbutnotwin",playedbutnotwin);
            PlayerPrefs.SetFloat("angryloginhousedie",angryloginhousedie);
            PlayerPrefs.SetFloat("w_AXE",w_AXE);
            PlayerPrefs.SetFloat("getDodge",getDodge);
            //currentmainmission
            PlayerPrefs.SetString("mainmissionnow",mainmissionnow.text);
            //SkillPoint
            PlayerPrefs.SetInt("totalSkillPoint",save2.totalSkillPoint);
            //savedsound only
            GetComponent<AudioSource>().Play();
            saved.SetActive(true);
           SceneManager.LoadScene(activeScene);
        }
        else{
            saved.SetActive(false);
        }        
    }
}