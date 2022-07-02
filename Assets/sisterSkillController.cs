using UnityEngine;using UnityEngine.UI;public class sisterSkillController:MonoBehaviour{
    public GameObject healskillFX1,healskillFX2,healUI;
    public wAXE_health wAXE_health;
    public float healcount = 30;
    public float healcooldown = 30;
    public Text cooldowntext;
    public AudioSource healskillsound,usehealskillsound, skillnotavailable;
    Animator anim;
    void Start(){
        anim=GetComponent<Animator>();
    }    
    void Update()
    {
        if(healcount==30&& Input.GetKeyDown(KeyCode.L) && anim.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {
            anim.SetTrigger("healskill");
        }
        if (healcount == 0)
        {
            cooldowntext.text = healcooldown.ToString();
            healcooldown -= 1 * Time.deltaTime;
        }
        if (healcooldown <= 0)
        {
            healcount = 30;
            healUI.GetComponent<Image>().color = Color.white;
            healcooldown = 30;
            cooldowntext.text = "";
        }
        if (healcount != 30 && Input.GetKeyDown(KeyCode.L))
        {
            skillnotavailable.Play();
        }
    }
    public void HealskillStart(){
        usehealskillsound.Play();
        healcount-=30;
        healUI.GetComponent<Image>().color=Color.red;
        healskillFX1.SetActive(true);
        healskillFX2.SetActive(true);        
        healskillsound.Play();
        wAXE_health.currentHealth += 30;
    }
    public void Healskill1End()
    {
        healskillFX1.SetActive(false);
        healskillFX2.SetActive(false); anim.ResetTrigger("hurt");
    }
}