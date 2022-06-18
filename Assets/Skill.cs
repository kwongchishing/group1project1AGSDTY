using UnityEngine;using UnityEngine.UI;public class Skill:MonoBehaviour{
    public GameObject lightingskillSound,electricskill,buttoninprison,correctcollider,Player,electricUI,getskillcollider,electricskill2;
    public save2 save2;
    public float electriccount=30;
    public float electriccooldown=30;
    public Text cooldowntext;
    public sentenceFunction sentenceFunction;
    public AudioSource buttonSound,unlockfinalbossdoor,getskillsound,useelectricskillsound,skillnotavailable;
    Animator anim;
    void Start(){
        anim=Player.GetComponent<Animator>();}
    public void useElectricSkillinprisonStart(){
        anim.SetBool("stop",true);
        anim.SetBool("stop",false);
        lightingskillSound.SetActive(true);
        electricskill.SetActive(true);
        buttonSound.Play();
        buttoninprison.SetActive(false);
        save2.finishsentence++;}
    public void useElectricSkillinprisonEnd(){
        unlockfinalbossdoor.Play();
        sentenceFunction.correctcount=6;
        lightingskillSound.SetActive(false);
        electricskill.SetActive(false);
        Player.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
        Player.GetComponent<Rigidbody>().constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationZ;
        correctcollider.SetActive(false);
        electricUI.SetActive(true);
        getskillsound.Play();
        getskillcollider.SetActive(true); anim.SetBool("stop",false);}
    void Update(){
        if(save2.finishsentence>0&&electriccount==30&&Input.GetKeyDown(KeyCode.F)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded")){            
            anim.SetTrigger("skill1");
        }
        if(electriccount==0){
            cooldowntext.text=electriccooldown.ToString();
            electriccooldown-=1*Time.deltaTime;
        }
        if(electriccooldown<=0){
            electriccount=30;
            electricUI.GetComponent<Image>().color=Color.white;
            electriccooldown=30;
            cooldowntext.text="";
        }
        if(save2.finishsentence>0&&electriccount!=30&&Input.GetKeyDown(KeyCode.F)){
            skillnotavailable.Play();
        }
    }
    public void skill1Start(){
            electriccount-=30;
        electricUI.GetComponent<Image>().color=Color.red;
            electricskill2.SetActive(true);
        useelectricskillsound.Play();
        lightingskillSound.SetActive(true);       
    }
    public void skill1End(){
        electricskill2.SetActive(false);
        lightingskillSound.SetActive(false);
        anim.ResetTrigger("hurt");
    }
}