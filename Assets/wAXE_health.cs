using UnityEngine;using UnityEngine.UI;using UnityEngine.SceneManagement;public class wAXE_health:MonoBehaviour{
    public float bigfoxhitcount,maxHealth,currentHealth,playerDefense,boss1hitcount,shieldmanhitcount,bullhitcount,guardhitcount,turtlehitcount,oldmanLeghitcount,unclehitcount,boyaunthitcount,sawTraphitcount,traphitcount,finalbosshitcount;
    public Ischange changeornot;
    public AudioSource punch,eatpotion,noitems,Weaponhitsound;
    public SaveDataBeforeDestroy SDBD;
    public save2 save2;
    public GameObject healParticle1,healParticle2;
    public boss1bipLookatPlayer boss1bipLookatPlayer;
    Animator anim;
    void Start(){
        if(changeornot.ischange<1&&save2.finishgame<1){
            maxHealth=SDBD.SDBD_maxHealth;
            currentHealth=SDBD.SDBD_health;
            playerDefense=SDBD.SDBD_defense;
if(save2.finishgame>0&&currentHealth<=0){
            currentHealth=100;
        }
        }
        anim=GetComponent<Animator>();        
    }
    void Update(){
        if(currentHealth<=0){
            Time.timeScale=0;
            SceneManager.LoadScene("playerdie");
        }
        //回血功能:
        if(currentHealth>0&&save2.point3finish<1&&Input.GetKeyDown(KeyCode.H)){
            if(save2.currentpotion>0){
                currentHealth+=20;
                eatpotion.Play();
                save2.currentpotion--;
                healParticle1.GetComponent<ParticleSystem>().Play();
                healParticle2.GetComponent<ParticleSystem>().Play();
            }
            else{noitems.Play();}
        }
        if(currentHealth>0&&save2.point3finish>0&&Input.GetKeyDown(KeyCode.H)){
            if(save2.currentpotion>0){
                currentHealth+=40;
                eatpotion.Play();
                save2.currentpotion--;
                healParticle1.GetComponent<ParticleSystem>().Play();
                healParticle2.GetComponent<ParticleSystem>().Play();
            }
            else{noitems.Play();}
        }
        if(currentHealth>maxHealth){currentHealth=maxHealth;}
        if(boss1hitcount>0.4f){
            anim.SetTrigger("hurt");
            boss1hitcount=0;
        }
        if(finalbosshitcount>9f){
            anim.SetTrigger("hurt");
            finalbosshitcount=0;
        }
        if(bigfoxhitcount>=1.8f){
            anim.SetTrigger("hurt");
            bigfoxhitcount=0;
        }
        if (bullhitcount >=1)
        {
            anim.SetTrigger("hurt");
            bullhitcount = 0;
        }
    }
    
    void OnTriggerEnter(Collider monster1){       
        if(monster1.gameObject.tag=="rubbish"){
            currentHealth=currentHealth-3f/playerDefense;anim.SetTrigger("hurt");
        }
        if(monster1.gameObject.tag=="uncleHandattack"){
            punch.Play();
            currentHealth=currentHealth-1f/playerDefense;
            unclehitcount+=0.001f;if(unclehitcount>=0.0015f){
                anim.SetTrigger("hurt");
                unclehitcount=0;
            }
        }
        if(monster1.gameObject.tag=="boywithWeapon"){
            currentHealth=currentHealth-1.1f/playerDefense;Weaponhitsound.Play();
            boyaunthitcount+=0.001f;if(boyaunthitcount>=0.0015f){
                anim.SetTrigger("hurt");
                boyaunthitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="boss1push"){
            currentHealth=currentHealth-0.4f/playerDefense;
            boss1hitcount+=0.03f;punch.Play();
        }
        if(monster1.gameObject.tag=="boss1rotatingBody"){
            currentHealth=currentHealth-0.2f/playerDefense; punch.Play();
            boss1hitcount=boss1hitcount+0.001f;
        }
        if(monster1.gameObject.tag=="humanmanshield"){
            currentHealth=currentHealth-1f/playerDefense;
            shieldmanhitcount+=0.004f;
        }
    if(monster1.gameObject.tag=="runningtrap"){
    currentHealth=currentHealth-1f/playerDefense;anim.SetTrigger("runninghit"); Weaponhitsound.Play();
        }
        if(monster1.gameObject.tag=="bull_weapon"){
            currentHealth=currentHealth-3f/playerDefense;
            bullhitcount+=0.2f;            
        }
        if(monster1.gameObject.tag=="bull_heavyweapon"){
            currentHealth=currentHealth-15f/playerDefense;
            bullhitcount++;
        }
        if(monster1.gameObject.tag=="guard_weapon"){
            currentHealth=currentHealth-1.2f/playerDefense;
            guardhitcount++;Weaponhitsound.Play();
            if(guardhitcount>=4){
                anim.SetTrigger("hurt");
                guardhitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="guard_heavyweapon"){
            currentHealth=currentHealth-2.2f/playerDefense;
            guardhitcount++;Weaponhitsound.Play();
            if(guardhitcount>3){
                anim.SetTrigger("hurt");
                guardhitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="turtleattack"){
            currentHealth=currentHealth-1.4f/playerDefense;
            turtlehitcount++;
            if(turtlehitcount>4){
                anim.SetTrigger("hurt");
                turtlehitcount=0;
            }
        }
        if(monster1.gameObject.tag=="OldmanLeg"){
            currentHealth=currentHealth-0.7f/playerDefense;
            oldmanLeghitcount++;
            if(oldmanLeghitcount>3){
                anim.SetTrigger("hurt");
                oldmanLeghitcount=0;
            }
        }
        if(monster1.gameObject.tag=="Arrow"){
            currentHealth=currentHealth-3f/playerDefense;
            anim.SetTrigger("hurt"); Weaponhitsound.Play();
        }
        if(monster1.gameObject.tag=="trap"){
            currentHealth=currentHealth-3f/playerDefense;Weaponhitsound.Play();
            traphitcount++;
            if(traphitcount>2){
                anim.SetTrigger("hurt");
                traphitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="speartrap"){
            currentHealth=currentHealth-3f/playerDefense;
            Weaponhitsound.Play();
            traphitcount++;
            if(traphitcount>2){
                anim.SetTrigger("hurt");
                traphitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="sawTrap"){
            currentHealth=currentHealth-3f/playerDefense;
            sawTraphitcount+=0.1f; Weaponhitsound.Play();
            if (sawTraphitcount>0.5f){
                anim.SetTrigger("hurt");
                sawTraphitcount=0; 
            }
        }
        if(monster1.gameObject.tag=="finalbossweapon"){
            currentHealth=currentHealth-1f/playerDefense;
            finalbosshitcount++; punch.Play();
        }
        if(monster1.gameObject.tag=="finalbosselectric"){
            currentHealth=currentHealth-3f/playerDefense;
            finalbosshitcount+=4;
        }
        if(monster1.gameObject.tag=="finalbossstorm"){
            currentHealth=currentHealth-3f/playerDefense;
            finalbosshitcount++;
        }
        if(monster1.gameObject.tag=="finalbossfire"){
            currentHealth=currentHealth-0.5f/playerDefense;
            finalbosshitcount++;
        }
        if(monster1.gameObject.tag=="finalbossstone"){
            currentHealth=currentHealth-2f/playerDefense;
            finalbosshitcount+=8;
        }
        if(monster1.gameObject.tag=="bigfox"){
            currentHealth =currentHealth-5f/playerDefense;
            bigfoxhitcount += 0.4f;
        }
    }
    void OnTriggerStay(Collider monster1){        
        if(monster1.gameObject.tag=="boss1rotatingBody"){
            currentHealth=currentHealth-0.01f/playerDefense*Time.deltaTime;
            boss1hitcount=boss1hitcount+0.001f*Time.deltaTime;
            if(boss1hitcount>10){
                anim.SetTrigger("hurt");
                boss1hitcount=0;
                boss1bipLookatPlayer.pushcount=0;
            }
        }
        if(monster1.gameObject.tag=="runningtrap"){
            currentHealth=currentHealth-1f/playerDefense*Time.deltaTime; punch.Play();
            anim.SetTrigger("runninghit");
        }
            if(monster1.gameObject.tag=="finalbosselectric"){
            currentHealth=currentHealth-2.2f/playerDefense*Time.deltaTime;
            finalbosshitcount+=0.3f*Time.deltaTime;
        }
        if(monster1.gameObject.tag=="humanmanshield"){
            shieldmanhitcount+=0.09f*Time.deltaTime;
            if(shieldmanhitcount>=0.1f){
                anim.SetTrigger("hurt");
                shieldmanhitcount=0;
            }
        }
        if(monster1.gameObject.tag=="turtleattack"){
            currentHealth=currentHealth-1.4f/playerDefense*Time.deltaTime;
            turtlehitcount+=0.3f*Time.deltaTime;
            if(turtlehitcount>4){
                anim.SetTrigger("hurt");
                turtlehitcount=0;
            }
        }
        if(monster1.gameObject.tag=="sawTrap"){
            currentHealth=currentHealth-3f/playerDefense*Time.deltaTime;
            sawTraphitcount+=0.1f*Time.deltaTime;
            if(sawTraphitcount>0.23f){
                anim.SetTrigger("hurt");
                sawTraphitcount=0;
            }
        }
        if(monster1.gameObject.tag=="finalbossfire"){
            currentHealth=currentHealth-0.6f/playerDefense*Time.deltaTime;
            finalbosshitcount+=0.3f*Time.deltaTime;
        }
        if(monster1.gameObject.tag=="finalbosswater"){
            currentHealth=currentHealth-9f/playerDefense*Time.deltaTime;
            finalbosshitcount+=0.3f*Time.deltaTime;
        }
    }
}