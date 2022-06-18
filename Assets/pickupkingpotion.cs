using UnityEngine;using UnityEngine.UI;public class pickupkingpotion:MonoBehaviour{   
    public save2 save2;
    public GameObject thispotion;
    public AudioSource pickpotionsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            save2.currentpotion+=30;
            pickpotionsound.Play();
            this.gameObject.SetActive(false);
            Destroy(thispotion);
        }
        }   
}