using UnityEngine;public class lovexp:MonoBehaviour{
    public float currentLove,maxLove;
    public Transform Player1,Player2;
    public AudioSource feed;
    public save2 save2;
    public GameObject feedtext,feedtextsister,feedFX;
    void Start(){
        maxLove=200f;
        currentLove=0f;
    }    
    void Update(){
        if (Vector3.Distance(Player1.transform.position, transform.position) < 4f)
        {
            feedtext.SetActive(true);
        }
        else { feedtext.SetActive(false); }
        if (Vector3.Distance(Player2.transform.position, transform.position )< 4f)
        {
            feedtextsister.SetActive(true);
        }
        else { feedtextsister.SetActive(false); }
        if (Input.GetKeyDown(KeyCode.Return)&&Vector3.Distance(Player1.transform.position,transform.position)<4f&&save2.currentpotion>0||Input.GetKeyDown(KeyCode.E)&&Vector3.Distance(Player1.transform.position,transform.position)<4f&&save2.currentpotion>0){
            feed.Play();
            feedFX.GetComponent<ParticleSystem>().Play();
            currentLove+=20f;
            save2.currentpotion--;
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)&&Vector3.Distance(Player2.transform.position,transform.position)<4f&&save2.currentpotion>0){
            feed.Play();
            feedFX.GetComponent<ParticleSystem>().Play();
            currentLove +=20f;
            save2.currentpotion--;
        }
    }
}