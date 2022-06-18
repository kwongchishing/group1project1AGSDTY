using UnityEngine;using UnityEngine.SceneManagement;using UnityEngine.UI;public class entertobedsave:MonoBehaviour{
    public GameObject Player,saved,directionallight;
    public save2 save2;
    public int activeScene;
    public wAXE_health hp;
    public WAXE_exp exp;
    public Text Pname;
    public AudioSource chickenmorningsound;
    public void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            save2.newgamesaved=1;
            directionallight.SetActive(false);
            directionallight.SetActive(true);
            PlayerPrefs.SetFloat("newgamesaved",save2.newgamesaved);
            PlayerPrefs.SetFloat("finishgame",save2.finishgame);
            PlayerPrefs.SetFloat("hp",hp.currentHealth);
            PlayerPrefs.SetFloat("defense",hp.playerDefense);
            PlayerPrefs.SetFloat("attack",exp.playerAttack);
            PlayerPrefs.SetFloat("exp",exp.currentExp);
            PlayerPrefs.SetFloat("maxexp",exp.maxExp);
            PlayerPrefs.SetFloat("level",exp.level);
            PlayerPrefs.SetFloat("potion",save2.currentpotion);
            PlayerPrefs.SetString("name",save2.Pname.text);
            PlayerPrefs.SetInt("currentMoney",save2.currentMoney);
            PlayerPrefs.SetInt("totalSkillPoint",save2.totalSkillPoint);
            PlayerPrefs.SetInt("point1finish",save2.point1finish);
            PlayerPrefs.SetInt("point2finish",save2.point2finish);
            PlayerPrefs.SetInt("point3finish",save2.point3finish);
            PlayerPrefs.SetInt("point4finish",save2.point4finish);
            PlayerPrefs.SetInt("point5finish",save2.point5finish);
            PlayerPrefs.SetInt("point6finish",save2.point6finish);
            PlayerPrefs.SetInt("point7finish",save2.point7finish);
            PlayerPrefs.SetFloat("bull_kingisdead",save2.bull_kingisdead);
            PlayerPrefs.SetFloat("bull_kingisdead1",save2.bull_kingisdead1);
            PlayerPrefs.SetFloat("bull_kingisdead2",save2.bull_kingisdead2);
            PlayerPrefs.SetFloat("bull_kingisdead3",save2.bull_kingisdead3);
            PlayerPrefs.SetFloat("sisterweapon",save2.sisterweapon);
            PlayerPrefs.SetFloat("defenseMaccept", save2.defenseMaccept);
            PlayerPrefs.SetFloat("defenseMfinish", save2.defenseMfinish);
            PlayerPrefs.SetFloat("defenseMfail", save2.defenseMfail);
            PlayerPrefs.SetFloat("findgirlMaccept", save2.findgirlMaccept);
            PlayerPrefs.SetFloat("findgirlMfinish", save2.findgirlMfinish);
            PlayerPrefs.SetFloat("mainmission1finish",save2.mainmission1finish);
            activeScene=SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("ActiveScene", activeScene);
            saved.SetActive(true);
            chickenmorningsound.Play();
            Player.transform.position=new Vector3(976.594421f,-117.409554f,-115.610641f);
        }
    }
}