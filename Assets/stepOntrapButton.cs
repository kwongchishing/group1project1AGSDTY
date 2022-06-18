using UnityEngine;public class stepOntrapButton:MonoBehaviour{
    public GameObject trapBGmusic,trap1,trap2,trap3,trap4,Btrap1,Btrap2,saw1,saw2,saw3,saw4,saw5,saw6,saw7,axe1,axe2,axe3,hammer1,hammer2; 
    public AudioSource trapStart;
    public save2 save2;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            GetComponent<Animator>().SetBool("StepOn",true);
            trapBGmusic.SetActive(true);
            trapStart.Play();
            save2.trapisstep++;
            trap1.GetComponent<Animation>().enabled=true;
            trap2.GetComponent<Animation>().enabled=true;
            trap3.GetComponent<Animation>().enabled=true;
            trap4.GetComponent<Animation>().enabled=true;
            Btrap1.GetComponent<Animation>().enabled=true;
            Btrap2.GetComponent<Animation>().enabled=true;
            saw1.GetComponent<Animation>().enabled=true;
            saw2.GetComponent<Animation>().enabled=true;
            saw3.GetComponent<Animation>().enabled=true;
            saw4.GetComponent<Animation>().enabled=true;
            saw5.GetComponent<Animation>().enabled=true;
            saw6.GetComponent<Animation>().enabled=true;
            saw7.GetComponent<Animation>().enabled=true;
            axe1.GetComponent<Animation>().enabled=true;
            axe2.GetComponent<Animation>().enabled=true;
            axe3.GetComponent<Animation>().enabled=true;
            hammer1.GetComponent<Animation>().enabled=true;
            hammer2.GetComponent<Animation>().enabled=true;
        }
    }
}