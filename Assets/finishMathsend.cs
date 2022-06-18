using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class finishMathsend:MonoBehaviour{
    public int activeScene;
    public GameObject entertocontinue,mathsNPCcollider, potion1, potion2, potion3, mainmissiontext, player, firstangrylog, moneybag, potionCount, expbar, healthbar, Playername, icon, howtoplay, startmission, starttext,pressEnterornot,MathPanel;
    public AudioSource cancelTestsound,test1Music;
    public correctCount cc;
    public Save save;
    public Health hp;
    public Exp exp;
    public Text mainmissionnow, Pname;
    public save2 save2;
    void Update(){
        test1Music.Stop();
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.SetActive(true);
            entertocontinue.SetActive(false);
            player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
            player.transform.position = new Vector3(319.32f, 50.4061f, 277.33f);
            player.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = true;            
            cc.retryOrnot += 1;
            mathsNPCcollider.SetActive(true);
            pressEnterornot.SetActive(true);
            cancelTestsound.Play();
            MathPanel.SetActive(false);
            this.gameObject.SetActive(false);
            PlayerPrefs.SetFloat("mcgoodbadcount", save2.goodbadcount);
            PlayerPrefs.SetFloat("mchp", hp.currentHealth);
            PlayerPrefs.SetFloat("mcdefense", hp.playerDefense);
            PlayerPrefs.SetFloat("mcattack", exp.playerAttack);
            PlayerPrefs.SetFloat("mcexp", exp.currentExp);
            PlayerPrefs.SetFloat("mcmaxexp", exp.maxExp);
            PlayerPrefs.SetFloat("mclevel", exp.level);
            PlayerPrefs.SetString("mcname", Pname.text);
            PlayerPrefs.SetInt("mccurrentMoney", save2.currentMoney);
            PlayerPrefs.SetFloat("mcpotion", save2.currentpotion);
            PlayerPrefs.SetFloat("mcgetbrokenaxe", save.getbrokenaxe);
            PlayerPrefs.SetFloat("mcpotion1des", save2.potion1des);
            PlayerPrefs.SetFloat("mcpotion2des", save2.potion2des);
            PlayerPrefs.SetFloat("mcpotion3des", save2.potion3des);
            PlayerPrefs.SetFloat("mcPlayerX", player.transform.position.x);
            PlayerPrefs.SetFloat("mcPlayerY", player.transform.position.y);
            PlayerPrefs.SetFloat("mcPlayerZ", player.transform.position.z);
            PlayerPrefs.SetFloat("mcRotationX", player.transform.eulerAngles.x);
            PlayerPrefs.SetFloat("mcRotationY", player.transform.eulerAngles.y);
            PlayerPrefs.SetFloat("mcRotationZ", player.transform.eulerAngles.z);
            PlayerPrefs.SetFloat("mcretryOrnot", cc.retryOrnot);
            PlayerPrefs.SetFloat("mcfirstTimeandNotready", cc.firstTimeandNotready);
            PlayerPrefs.SetString("mcmainmissionnow", mainmissionnow.text);
            PlayerPrefs.SetInt("mctotalSkillPoint", save2.totalSkillPoint);
            activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeScene);
        }
    }

}
