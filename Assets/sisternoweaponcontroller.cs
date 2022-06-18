using UnityEngine;public class sisternoweaponcontroller:MonoBehaviour{
    public save2 save2;
    public AudioSource sisterdamage,dodgesound, sisterattack2, sisterattack1;
    Animator anim;
    public GameObject healFXp1,healFXp2,LeftLeg,RightLeg;
    BoxCollider Bcollider,Ccollider;
    void Start(){
        anim=GetComponent<Animator>();
        Bcollider = LeftLeg.GetComponent<BoxCollider>();
        Ccollider = RightLeg.GetComponent<BoxCollider>();
    }
    void Update(){
        if(save2.sisterweapon<1&&Input.GetKeyDown(KeyCode.LeftArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){anim.SetTrigger("sisterlightcombo");}
        if(save2.sisterweapon<1&&Input.GetKeyDown(KeyCode.RightArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){anim.SetTrigger("sisterheavycombo");}
    }
    public void lightattacklegstart(){
        healFXp1.SetActive(false);
        healFXp2.SetActive(false);
        Ccollider.enabled=false;
        sisterattack1.Play();
        Bcollider.enabled=true;
    }
    public void lightattacklegend(){
        healFXp1.SetActive(false);
        healFXp2.SetActive(false);Bcollider.enabled=false;Ccollider.enabled=false;anim.ResetTrigger("hurt");
    }
    public void heavyattacklegstart(){
        healFXp1.SetActive(false);
        healFXp2.SetActive(false);
        sisterattack2.Play();
        Bcollider.enabled=false;
        Ccollider.enabled=true;
    }
    public void heavyattacklegend(){
        Ccollider.enabled=false;Bcollider.enabled=false;anim.ResetTrigger("hurt");
    }
    public void sisterIdlestart(){
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false);
    }
    public void sisterIdleend(){
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false);
    }
    public void sisterdodgestart(){
        dodgesound.Play();Ccollider.enabled=false;Bcollider.enabled=false;anim.ResetTrigger("hurt");healFXp1.SetActive(false);
        healFXp2.SetActive(false);
    }
    public void sisterdodgeend(){
        anim.ResetTrigger("hurt");Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false);
    }
    public void sisterHurtStart(){
        sisterdamage.Play();
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false);
    }
    public void sisterHurtEnd(){
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false);
        anim.ResetTrigger("hurt");
    }
}