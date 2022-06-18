using UnityEngine;public class entertocontinueWithgetitemSound:MonoBehaviour{
    public GameObject unlockcoopmode;
    public AudioSource getitemsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            getitemsound.Play();
            unlockcoopmode.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}