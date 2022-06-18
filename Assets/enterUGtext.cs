using UnityEngine;public class enterUGtext:MonoBehaviour{
    public AudioSource musicbg2,musicbg1,UG1music,updownStairSound;
    public GameObject All_BullEnemy,minimap, DirectionalLight,underground,Player,leaveText,mmpointer,pstonepointer,oldmmpointer;
    public save2 save2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            if(Player==null) Player=GameObject.FindWithTag("Player");
            underground.SetActive(true);
            Player.transform.position=new Vector3(3.8561995f,0.0673588348f,-305.300873f);
            updownStairSound.Play();
            minimap.SetActive(false);
            leaveText.SetActive(false);
            mmpointer.SetActive(false);
            musicbg2.Stop();
            musicbg1.Stop();
            DirectionalLight.GetComponent<Light>().intensity=0;
            UG1music.Play();
            if(save2.collectedkey>0){
                All_BullEnemy.SetActive(true);
            }
            if(pstonepointer!=null) pstonepointer.SetActive(false);
            if(oldmmpointer!=null) oldmmpointer.SetActive(false);
        }
    }
}