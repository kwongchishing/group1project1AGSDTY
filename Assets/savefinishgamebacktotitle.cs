using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class savefinishgamebacktotitle:MonoBehaviour{
    public save2 save2;
    public wAXE_health hp;
    public WAXE_exp exp;
    public Text Pname;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            save2.finishgame++;
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
            SceneManager.LoadScene("title");
        }
    }
    public void savefinishgame(){
        save2.finishgame++;
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
        SceneManager.LoadScene("title");
    }
}