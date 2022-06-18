using UnityEngine;public class changePlayerfaveAXE:MonoBehaviour{
    public GameObject enterTocontinue,punchUI,axeUI,w_AXEplayer,Canvas,w_AXE,Sporthouseentercollider,AngryLog002,AngryLog003,AngryLog005,Mainmission1,Mainmission2,savenpc1,savenpc2,expbar1,expbar2,healthbar1,healthbar2,minimapiconGate,minimapiconmchouse;
    public Ischange changeornot;
    void Start(){
        w_AXE.SetActive(true);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            Destroy(Mainmission1);
            Mainmission2.SetActive(true);
            Destroy(Sporthouseentercollider);            
            Destroy(Canvas);            
            savenpc1.SetActive(false);
            savenpc2.SetActive(true);
            Destroy(healthbar1);
            healthbar2.SetActive(true);
            Destroy(expbar1);
            expbar2.SetActive(true);
            Destroy(punchUI);
            axeUI.SetActive(true);
            Destroy(enterTocontinue);
            changeornot.ischange+=1; minimapiconmchouse.SetActive(false); minimapiconGate.SetActive(true);
            w_AXEplayer.gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled=true;
            Destroy(this.gameObject);Destroy(AngryLog002);Destroy(AngryLog003);Destroy(AngryLog005);
        }
    }
}