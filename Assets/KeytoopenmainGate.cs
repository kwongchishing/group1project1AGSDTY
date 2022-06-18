using UnityEngine;using UnityEngine.UI;public class KeytoopenmainGate:MonoBehaviour{
    public save2 save2;
    public AudioSource getitemSound;
    public GameObject mainmission2GATEcollider,Pstonehousearrow, leftgate,rightgate,maingateisLock,minimapiconGate,mainmission2text,mainmission3text;
    Animator animL;
    Animator animR;
    public Text saveNPCtext;
    void Start(){
        animL=leftgate.GetComponent<Animator>();
        animR=rightgate.GetComponent<Animator>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            if(save2.collectedkey>0){
                getitemSound.Play();
                save2.gateopened++;
                Pstonehousearrow.SetActive(true);
                animL.SetBool("open",true);
                animR.SetBool("open",true);minimapiconGate.SetActive(false);
                mainmission2text.SetActive(false);
                mainmission3text.SetActive(true);
                saveNPCtext.text="左翼天使：其實人類一早就視你為敵人......按下Enter / E鍵，我會把你目前為止的表現報告給那位大人......";
                Destroy(mainmission2GATEcollider);
            }
            if(save2.collectedkey<1){
                this.gameObject.SetActive(false);
                maingateisLock.SetActive(true);                
            }
        }
    }    
}