using UnityEngine;public class lovexp3:MonoBehaviour{
    public float currentLove,maxLove;
    public Transform Player1,Player2;
    public AudioSource petlevelupsound,feed;
    public save2 save2;
    public GameObject pet3,pet4,feedtext,feedtextsister,feedFX;
    void Start(){
        currentLove=0f;maxLove=500f;
        if(PlayerPrefs.HasKey("currentLove3")) currentLove=PlayerPrefs.GetFloat("currentLove3");
    }
    void Update(){
        if(Vector3.Distance(Player1.transform.position, transform.position) < 3f){
            feedtext.SetActive(true);
        }
        else { feedtext.SetActive(false); }
        if (Vector3.Distance(Player2.transform.position, transform.position) < 3f)
        {
            feedtextsister.SetActive(true);
        }
        else { feedtextsister.SetActive(false); }
        if (Input.GetKeyDown(KeyCode.Return) && Vector3.Distance(Player1.transform.position, transform.position) < 3f && save2.currentpotion > 0 || Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Player1.transform.position, transform.position) < 3f && save2.currentpotion > 0)
        {
            feed.Play();
            feedFX.GetComponent<ParticleSystem>().Play();
            currentLove += 20f;
            save2.currentpotion--;
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && Vector3.Distance(Player2.transform.position, transform.position) < 3f && save2.currentpotion > 0)
        {
            feed.Play();
            feedFX.GetComponent<ParticleSystem>().Play();
            currentLove += 20f;
            save2.currentpotion--;
        }
        if(currentLove>=500f){
            save2.petStart=4;
            pet4.SetActive(true);
            pet3.SetActive(false);
            petlevelupsound.Play();
        }
    }
}