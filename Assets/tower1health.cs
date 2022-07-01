using UnityEngine;public class tower1health:MonoBehaviour{
    public AudioSource die,gethit;
    public float currentHealth,maxHealth,hitbymonstercount;
    public save2 save2;
    public Transform fox5,fox, fox2,fox3,fox4;
    public GameObject defenseminimapicon,missionfailcanvas,TowerhealthCanvas,fire7,fire8,fire5,fire6,fire3,fire4,fire1,bgm1,defensebgm,defenseTowerFX,defendtowermonster,All_colliWall;
    void Start(){
        currentHealth=5000f;
        maxHealth=5000f;
    }
    void Update(){
        if(hitbymonstercount>5){
            gethit.Play();
            hitbymonstercount=0;
        }

        if(currentHealth<=0)//lose
        {
            die.Play();
            save2.defenseMfinish++;
            save2.defenseMfail++;
            Destroy(All_colliWall);
            Destroy(defendtowermonster);
            Destroy(defenseTowerFX);
            defensebgm.SetActive(false);
            bgm1.SetActive(true);
            missionfailcanvas.SetActive(true);
            Destroy(TowerhealthCanvas);
            Destroy(defenseminimapicon);
            Destroy(this.gameObject);
        }
        if (currentHealth<=4000){
            fire1.SetActive(true);
        }
        if(currentHealth<=3000){
            fire3.SetActive(true);
            fire4.SetActive(true);
        }
        if(currentHealth<=2000){
            fire6.SetActive(true);
            fire5.SetActive(true);
        }
        if(currentHealth<=1000){
            fire7.SetActive(true);
            fire8.SetActive(true);
        }
    }
}