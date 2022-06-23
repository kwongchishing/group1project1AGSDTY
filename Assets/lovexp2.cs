using UnityEngine;public class lovexp2:MonoBehaviour{
    public float currentLove,maxLove;
    public Transform Player1,Player2;
    public AudioSource petlevelupsound,feed;
    public save2 save2;
    public GameObject pet2,pet3,feedtext,feedtextsister,feedFX;
    void Start(){
        currentLove=0f;maxLove=300f;        
    }
    void Update(){
                   if (Vector3.Distance(Player1.transform.position, transform.position) < 3f)
            {
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
            if (currentLove >= 300f)
            {
                save2.petStart = 3;
                pet3.SetActive(true);
                pet2.SetActive(false);
            petlevelupsound.Play();
        }
        }    
}