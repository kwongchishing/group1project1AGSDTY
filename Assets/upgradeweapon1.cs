using UnityEngine;public class upgradeweapon1:MonoBehaviour{
    public save2 save2;
    public AudioSource forging,buysound;
    public WAXE_exp WAXE_exp;
    public GameObject fx1,fx2,fx3,fx4,fx5;
    public void clickbuyupgrade(){
        if(save2.shitcount>=2){
            save2.shitcount-=2;
            WAXE_exp.playerAttack+=0.5f;
            forging.Play();
            buysound.Play();
            fx1.GetComponent<ParticleSystem>().Play();
            fx2.GetComponent<ParticleSystem>().Play();
            fx3.GetComponent<ParticleSystem>().Play();
            fx4.GetComponent<ParticleSystem>().Play();
            fx5.GetComponent<ParticleSystem>().Play();
        }
    }
}