using UnityEngine;public class leaveMathshouse1:MonoBehaviour{
    public GameObject player,Mathselearnhouse,minimap,mmpointer;
    public Save save;
    public AudioSource backgroundmusic1,NPCdiemusic,opendoorsound;
    void Update(){        
        if(Input.GetKeyDown(KeyCode.Return)&&save.w_AXE<1|| Input.GetKeyDown(KeyCode.E) && save.w_AXE < 1)
        {
backgroundmusic1.Play();
            NPCdiemusic.Stop();
            player.transform.position=new Vector3(323.76f,31.684f,280.1f);
            player.transform.rotation=Quaternion.Euler(0,91.562f,0);
            opendoorsound.Play();
            mmpointer.SetActive(true);
            Mathselearnhouse.SetActive(false);
            minimap.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}