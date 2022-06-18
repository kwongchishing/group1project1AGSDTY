using UnityEngine;public class AXE_Text3:MonoBehaviour{
    public GameObject getaxeIMG,getaxeText;
    public AudioSource getitemsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            getaxeIMG.SetActive(true);
            getaxeText.SetActive(true);
            getitemsound.Play();
            Destroy(this.gameObject);
        }
    }
}