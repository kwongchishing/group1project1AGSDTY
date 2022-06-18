using UnityEngine;using UnityEngine.UI;public class Ostone0or1:MonoBehaviour{
    public save2 save2;public GameObject noOstone,OstonePlace,Ostonefinish; public AudioSource getitemsound;
    public Text Ostonetext;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            if(save2.letterOstone<1){
                noOstone.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if(save2.letterOstone>0){
                getitemsound.Play();
                noOstone.SetActive(true);
                Ostonetext.text="放入了 O 塊";
                save2.finishOstone++;
                Destroy(noOstone,2f);
                Destroy(OstonePlace);
                Destroy(this.gameObject);
                Ostonefinish.SetActive(true);
            }
        }
    }
}