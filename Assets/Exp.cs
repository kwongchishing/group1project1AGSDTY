using UnityEngine;using UnityEngine.UI;public class Exp:MonoBehaviour{
    public float maxExp,currentExp,level;
    public Health pDefense;
    public float playerAttack=1.0f;
    public float expcarrytonextlevel=0;
    public save2 save2;
    public GameObject LevelUpText2;
    public AudioSource levelupSound;
    Animator levelupanim;
    Animator anim;
    void Start(){
        anim=GetComponent<Animator>();
        levelupanim=LevelUpText2.GetComponent<Animator>();
        if(playerAttack<=0) playerAttack=1;
        if(level<=0) level=1;
        if(maxExp<100) maxExp=100;
    }
    void Update(){
        if(currentExp>=maxExp){
            expcarrytonextlevel=currentExp-maxExp;
            pDefense.playerDefense++;            
            playerAttack+=0.2f;
            currentExp=0+expcarrytonextlevel;
            maxExp*=2;
            level++;
            save2.totalSkillPoint+=1;
            LevelUpText2.SetActive(true);
            levelupSound.Play();
            levelupanim.SetBool("Show",true);
        }
        expcarrytonextlevel=0;
    }
}