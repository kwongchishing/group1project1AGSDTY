using UnityEngine;public class sisternoweaponcontroller:MonoBehaviour{
    public save2 save2;
    public AudioSource hahahasound,sisterdamage, dodgesound,sisterattack2,sisterattack1;
    Animator anim;
    public GameObject sisterheavyweapon,sisterslashVFX,sisterweapon,healFXp1,healFXp2,LeftLeg,RightLeg;
    BoxCollider Bcollider,Ccollider,Hcollider;
    MeshCollider Wcollider;
    void Start(){
        anim=GetComponent<Animator>();
        Bcollider=LeftLeg.GetComponent<BoxCollider>();
        Ccollider=RightLeg.GetComponent<BoxCollider>();
        Hcollider= sisterheavyweapon.GetComponent<BoxCollider>();
        Wcollider =sisterweapon.GetComponent<MeshCollider>();
    }
    void Update(){
        if(save2.sisterweapon<1&&Input.GetKeyDown(KeyCode.LeftArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){anim.SetTrigger("sisterlightcombo");}
        if(save2.sisterweapon<1&&Input.GetKeyDown(KeyCode.RightArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){anim.SetTrigger("sisterheavycombo");}
        if(save2.sisterweapon>0&&Input.GetKeyDown(KeyCode.LeftArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){anim.SetTrigger("LightAttack");}
        if(Input.GetKeyDown(KeyCode.LeftArrow)&&anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack")){anim.SetTrigger("lightcombo2");}
        if (Input.GetKeyDown(KeyCode.LeftArrow) && anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo2")) { anim.SetTrigger("lightcombo3"); }
        if (save2.sisterweapon > 0 && Input.GetKeyDown(KeyCode.RightArrow) && anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")) { anim.SetTrigger("HeavyAttack"); }
    }
    public void lightslash1start(){
        Wcollider.enabled=true; sisterslashVFX.SetActive(true);
        sisterattack1.Play();
    }
    public void lightslash1end(){
        Wcollider.enabled=false; sisterslashVFX.SetActive(false); anim.ResetTrigger("hurt");
    }
    public void heavyslashstart()
    {
        Wcollider.enabled = false;
        Hcollider.enabled = true; sisterslashVFX.SetActive(true);
        sisterattack2.Play();
    }
    public void heavyslashend()
    {
        Wcollider.enabled = false;
        Hcollider.enabled = false; sisterslashVFX.SetActive(false); anim.ResetTrigger("hurt");
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
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
    }
    public void sisterIdleend(){
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
    }
    public void sisterdodgestart(){
        dodgesound.Play();Ccollider.enabled=false;Bcollider.enabled=false;anim.ResetTrigger("hurt");healFXp1.SetActive(false);
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
    }
    public void sisterdodgeend(){
        anim.ResetTrigger("hurt");Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
    }
    public void sisterHurtStart(){
        sisterdamage.Play();
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
    }
    public void sisterHurtEnd(){
        Ccollider.enabled=false;Bcollider.enabled=false;healFXp1.SetActive(false);
        healFXp2.SetActive(false); Wcollider.enabled=false; sisterslashVFX.SetActive(false); Hcollider.enabled = false;
        anim.ResetTrigger("hurt");
    }
    public void resethurt()
    {
        anim.ResetTrigger("hurt");
    }
    public void attack1sound()
    {
        sisterattack1.Play();
    }
    public void attack2sound()
    {
        sisterattack2.Play();
    }
    public void hahaha()
    {
        hahahasound.Play();
    }
}