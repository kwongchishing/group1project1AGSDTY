using UnityEngine;public class choosetopick:MonoBehaviour{
    public AudioSource chooseToPick;
    public GameObject coins;
    void Update(){
       if(Input.GetKeyDown(KeyCode.Return)){
            this.gameObject.SetActive(false);
                chooseToPick.Play();
            Destroy(coins);
        } 
    }
}