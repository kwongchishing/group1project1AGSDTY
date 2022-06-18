using UnityEngine;using UnityEngine.UI;public class WAXE_exp:MonoBehaviour{
    public wAXE_health HEALTH;
    public float playerAttack,expcarrytonextlevel,maxExp,currentExp,level;
    public Ischange changeornot;
    public Text levelcount;
    public GameObject LevelUpText2;
    public AudioSource levelupSound;
    Animator levelupanim;
    public SaveDataBeforeDestroy SDBD;
    public save2 save2;
    Animator anim;
    void Start(){
        if(changeornot.ischange<1&&save2.finishgame<1){
            maxExp=SDBD.SDBD_maxexp;
            currentExp=SDBD.SDBD_currentExp;
            expcarrytonextlevel=SDBD.SDBD_expcarrytonextlevel;
            playerAttack=SDBD.SDBD_playerAttack;
            level=SDBD.SDBD_level;
            levelcount.text=level.ToString();
        }
        anim=GetComponent<Animator>();
        levelupanim=LevelUpText2.GetComponent<Animator>();
    }
    void Update(){
        if(currentExp>=maxExp){
            expcarrytonextlevel=currentExp-maxExp;
            HEALTH.playerDefense+=1;
            playerAttack+=0.2f;
            currentExp=0+expcarrytonextlevel;
            maxExp*=2;
            level+=1;
            save2.totalSkillPoint+=1;
            LevelUpText2.SetActive(true);
            levelupSound.Play();
            levelcount.text=level.ToString();
            levelupanim.SetBool("Show",true);
        }
        expcarrytonextlevel=0;
    }
}