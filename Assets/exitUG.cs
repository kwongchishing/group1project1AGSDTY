using UnityEngine;public class exitUG:MonoBehaviour{
    public GameObject underground,Player,minimap,DirectionalLight,mmpointer,pstonepointer, oldmmpointer;
    public save2 save2;
    public Ischange Ischange;
    public AudioSource UG1music,updownStairSound,musicbg1,musicbg2;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.E)){
            if(Player==null) Player=GameObject.FindWithTag("Player");
            Player.transform.position=new Vector3(418.279785f,30.6595092f,303.147095f);
            UG1music.Stop();            
            if(Ischange.ischange>0&&save2.collectedkey<1&&save2.letterOstone<1) musicbg2.Play();
            if(Ischange.ischange<1) musicbg1.Play();
            if(Ischange.ischange>0&&save2.collectedkey>0) musicbg1.Play();
            minimap.SetActive(true);
            updownStairSound.Play(); DirectionalLight.GetComponent<Light>().intensity=1.1f;
            underground.SetActive(false);
            if(save2.gateopened<1) mmpointer.SetActive(true);
            if(save2.finishOstone<1&&save2.gateopened>0) mmpointer.SetActive(true);
            if(save2.finishOstone>0&&save2.finishPstone>0 && save2.gateopened > 0) mmpointer.SetActive(true);
            if(save2.finishPstone<1&&pstonepointer!=null && save2.gateopened > 0) pstonepointer.SetActive(true);
            if(oldmmpointer!=null) oldmmpointer.SetActive(true);
        }
    }}