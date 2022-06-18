using UnityEngine;public class collectKey:MonoBehaviour{
    public save2 save2;
    public AudioSource getitemSound;
    public GameObject getkeyimgText,theKey,leavecollider,Player,entertocontinue;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&& Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded") || Input.GetKeyDown(KeyCode.E) && Player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {
            Player.GetComponent<Animator>().SetBool("stop",true);            
            save2.collectedkey+=1;
            getitemSound.Play();            
            getkeyimgText.SetActive(true);
            entertocontinue.SetActive(true);
            leavecollider.SetActive(false);          
            Destroy(theKey);
            Destroy(this.gameObject);
        }        
    }
}