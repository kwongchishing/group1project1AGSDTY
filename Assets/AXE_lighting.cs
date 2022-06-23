using UnityEngine;public class AXE_lighting:MonoBehaviour{
    public camerashake camerashake;
    public AudioSource gethurt; public GameObject electricskill,AXE, combo3stormFX; public bool lighting,heavying;public AudioSource lightingSound,heavycombo2Sound,lightslashSound,heavyslashSound,heavyingSound,lightaxecombo2sound,lightaxecombo3sound,combo3StormFXsound;
    Animator anim;
    void Start(){
        anim=GetComponent<Animator>();
    }
    void Update(){
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("LightAttack")&&Input.GetButtonDown("Fire1")){
            anim.SetTrigger("lightcombo2"); 
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("lightcombo2")&&Input.GetButtonDown("Fire1")){
            anim.SetTrigger("lightcombo3"); 
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("HeavyAttack")&&Input.GetButtonDown("Fire2")){
            anim.SetTrigger("heavycombo2");
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("hurt")&&Input.GetButtonDown("Fire1")){
            anim.SetTrigger("LightAttack");
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("hurt")&&Input.GetButtonDown("Fire2")){
            anim.SetTrigger("HeavyAttack");
        }
    }
   public void lightingstart(){
        heavying=false;lighting=true;
        lightingSound.Play();
        lightslashSound.Play();
        AXE.SetActive(true);
    }
    public void lightingend(){
        lighting=false;
        AXE.SetActive(false);
        AXE.SetActive(true);
        anim.ResetTrigger("hurt");
    }
    public void heavyingstart(){
        lighting=false; heavying =true;
        heavyingSound.Play();
        heavyslashSound.Play();
        AXE.SetActive(true);
    }
    public void heavyingend(){
        heavying=false;
        AXE.SetActive(false);
        AXE.SetActive(true);
        anim.ResetTrigger("hurt");
    }
    public void nomove(){
        heavying=false;
        lighting=false; electricskill.SetActive(false); combo3stormFX.SetActive(false); anim.ResetTrigger("hurt");
    }
    public void runninghit(){
        anim.ResetTrigger("runninghit");
    }
    public void gethit(){
        heavying=false;
        lighting=false;
        combo3stormFX.SetActive(false);
        electricskill.SetActive(false);
        gethurt.Play();}
    public void gethitEnd(){
        heavying=false;
        lighting=false;
    }
    public void dodgeStartcancelattack(){
        anim.ResetTrigger("hurt");lighting=false;heavying=false;
    }
    public void dodgeEnd(){
        anim.ResetTrigger("hurt");lighting=false;heavying=false;
    }
    public void lightingcombo2start(){
        heavying=false; lighting =true;
        lightaxecombo2sound.Play();
        lightslashSound.Play();
        AXE.SetActive(true);
    }
    public void lightingcombo2end(){
        lighting=false;
        AXE.SetActive(false);
        AXE.SetActive(true);
        anim.ResetTrigger("hurt");
    }
    public void lightingcombo3start(){
        heavying=false; lighting =false;
        lightaxecombo3sound.Play();
        lightslashSound.Play();
        combo3stormFX.SetActive(true);
        AXE.SetActive(true); combo3StormFXsound.Play();
    }
    public void lightingcombo3end(){
        lighting=false;
        AXE.SetActive(false);
        AXE.SetActive(true);
        anim.ResetTrigger("hurt");
        combo3stormFX.SetActive(false);
    }
    public void axeMovesoundincombo2(){
        lightslashSound.Play();
    }
    public void heavycombo2start(){
        lighting = false; heavying =true;
        heavycombo2Sound.Play();
        heavyslashSound.Play();
        AXE.SetActive(true);
    }
    public void heavycombo2end(){
        lighting = false; heavying =false;
        AXE.SetActive(false);
        AXE.SetActive(true);
        anim.ResetTrigger("hurt");
    }
    public void shake(){
        camerashake.shakeDuration=0.007f;
    }
    public void smallshake()
    {
        camerashake.shakeDuration = 0.003f;
    }
    public void verysmallshake()
    {
        camerashake.shakeDuration = 0.001f;
    }
}