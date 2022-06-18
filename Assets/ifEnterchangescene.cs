using UnityEngine;public class ifEnterchangescene:MonoBehaviour{
    public GameObject player,insidehouse,minimap,diedNPC,liveNPC,AngryLoginhouse,AXE,mmpointer;
    public AudioSource backgroundmusic1,opendoorsound,NPCdieMusic;
    public Save save;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            insidehouse.SetActive(true);
            player.transform.position=new Vector3(329.3204f,50.4061f,277.8314f);
            opendoorsound.Play();
            mmpointer.SetActive(false);
            backgroundmusic1.Stop();
            minimap.SetActive(false);
            if(save.iron>0){
                NPCdieMusic.Play();
                diedNPC.SetActive(true);
                Destroy(liveNPC);
                AXE.SetActive(true);
                AngryLoginhouse.SetActive(true);
            }
        }
    }
}