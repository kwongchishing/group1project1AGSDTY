using UnityEngine;public class SaveDataBeforeDestroy:MonoBehaviour{
    public Health health;
    public float SDBD_health,SDBD_defense,SDBD_maxexp,SDBD_currentExp,SDBD_expcarrytonextlevel,SDBD_playerAttack,SDBD_maxHealth,SDBD_level;
    public Exp exp;
    //axeplayer getdata from here
    void Update(){
        SDBD_health=health.currentHealth;
        SDBD_defense=health.playerDefense;
        SDBD_maxexp=exp.maxExp;
        SDBD_currentExp=exp.currentExp;
        SDBD_expcarrytonextlevel=exp.expcarrytonextlevel;
        SDBD_playerAttack=exp.playerAttack;
        SDBD_maxHealth=health.maxHealth;
        SDBD_level=exp.level;}}