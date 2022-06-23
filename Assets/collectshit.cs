using UnityEngine;public class collectshit:MonoBehaviour{
    public GameObject shit;
    public save2 save2;
    public petlove4 petlove;
    public AudioSource getitem;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            getitem.Play();
            shit.SetActive(false);
            save2.shitcount++;
            petlove.isshit=false;
            this.gameObject.SetActive(false);
        }
    }
}