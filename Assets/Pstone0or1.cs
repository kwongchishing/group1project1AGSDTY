using UnityEngine;using UnityEngine.UI;public class Pstone0or1:MonoBehaviour{
    public save2 save2; public GameObject noPstone,PstonePlace,Pstonefinish;public AudioSource getitemsound;
    public Text Pstonetext;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterPstone<1){
                noPstone.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(save2.letterPstone>0){
                getitemsound.Play();
                noPstone.SetActive(true);
                Pstonetext.text="放入了 P 塊";
                save2.finishPstone++;
                Destroy(noPstone, 2f);
                Destroy(PstonePlace);
                Destroy(this.gameObject);
                Pstonefinish.SetActive(true);
            }
        }
    }
}