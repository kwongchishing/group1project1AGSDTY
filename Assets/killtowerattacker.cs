using UnityEngine;public class killtowerattacker:MonoBehaviour{
    public float killcount;
    public WAXE_exp WAXE_exp;
    public GameObject missionsuccesscanvas,TowerhealthCanvas,missionfailcanvas,bgm1,defensebgm,defenseTowerFX,defendtowermonster,All_colliWall;
    public save2 save2;
    void Update(){
        if (killcount>=19){            
            save2.defenseMfinish++;
            Destroy(All_colliWall);
            WAXE_exp.currentExp+=600;
            Destroy(defendtowermonster);
            Destroy(defenseTowerFX);
            defensebgm.SetActive(false);
            bgm1.SetActive(true);
            Destroy(missionfailcanvas);
            missionsuccesscanvas.SetActive(true);
            Destroy(TowerhealthCanvas);
            Destroy(this.gameObject);
        }
    }
}
