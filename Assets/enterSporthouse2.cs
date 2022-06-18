using UnityEngine;public class enterSporthouse2:MonoBehaviour{
    public GameObject player,house2,minimap,mmpointer;
    public AudioSource backgroundmusic1,opendoorsound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            house2.SetActive(true);
            player.transform.position=new Vector3(343.1711f,50.4061f,366.9536f);
            opendoorsound.Play();mmpointer.SetActive(false);
            backgroundmusic1.Stop();
            minimap.SetActive(false);}}}