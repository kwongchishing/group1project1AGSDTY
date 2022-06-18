using UnityEngine;public class blackpanelgamefinish:MonoBehaviour{
    public GameObject blackpanel,finishsavesisterstory;
    public AudioSource getitemsound;
    Animator anim;
    void Start(){
        anim=blackpanel.GetComponent<Animator>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            blackpanel.SetActive(true);
            finishsavesisterstory.SetActive(true);
            getitemsound.Play();
        }
    }
}