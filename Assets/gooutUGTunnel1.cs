using UnityEngine;public class gooutUGTunnel1:MonoBehaviour{
    public GameObject mmpointer,tunnelpointer,player,tunnel,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {            
            player.transform.position=new Vector3(360.260895f,9.5343895f,359.776337f);
            ropesound.Play(); DirectionalLight.GetComponent<Light>().intensity=1.1f;
            backgroundmusic4.SetActive(true);
            backgroundmusic5.SetActive(false);
            tunnelpointer.SetActive(false);
            mmpointer.SetActive(true);
            minimap.SetActive(true);tunnel.SetActive(false);
        }
    }
}