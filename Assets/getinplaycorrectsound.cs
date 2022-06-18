using UnityEngine;using UnityEngine.UI;public class getinplaycorrectsound:MonoBehaviour{
    public AudioSource correctsound,useelectricskillsound;
    public Text NotallCorrectTxt,words1space,words2space,words3space,words4space,words5space;
    public GameObject NotAllCorrectTxt,Player;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            correctsound.Play();
            NotallCorrectTxt.text="我： "+words1space.text+words2space.text+words3space.text+words4space.text+words5space.text+" 原來是這樣!";
            NotAllCorrectTxt.SetActive(true);            
            Player.GetComponent<Animator>().SetBool("stop",true);Player.GetComponent<Animator>().SetBool("stop",false);
            Player.GetComponent<Animator>().SetTrigger("electricskill");
            useelectricskillsound.Play();
        }
    }
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            NotallCorrectTxt.text="我： "+words1space.text+words2space.text+words3space.text+words4space.text+words5space.text+" 原來是這樣!";
            NotAllCorrectTxt.SetActive(true);
        }
    }
}