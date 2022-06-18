using UnityEngine;public class choosepickngpick:MonoBehaviour{    
    public GameObject potion;
    public float currentpotion;
    public AudioSource pickpotionsound;
    public Ischange Ischange;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)&&Ischange.ischange<1|| Input.GetKeyDown(KeyCode.E) && Ischange.ischange < 1)
        {            
            save2.currentpotion++;            
            pickpotionsound.Play();
            save2.potion1des+=1;
            Destroy(potion);
        }
        if(Input.GetKeyDown(KeyCode.Return)&&Ischange.ischange>0|| Input.GetKeyDown(KeyCode.E) && Ischange.ischange > 0)
        {
            save2.currentpotion++;
            pickpotionsound.Play();
            save2.potion1des+=1;
            Destroy(potion);
        }
    }
}