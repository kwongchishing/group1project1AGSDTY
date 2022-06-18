using UnityEngine;public class insideUGTunnel4:MonoBehaviour{
    public GameObject mmpointer,tunnelpointer,player,tunnel,minimap,backgroundmusic1,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            tunnel.SetActive(true);
            player.transform.position=new Vector3(205.477188f,199.837662f,-1046.90186f);
            player.transform.rotation=Quaternion.Euler(0,90.086f,0);
            ropesound.Play();DirectionalLight.GetComponent<Light>().intensity=0;
            backgroundmusic1.SetActive(false);
            backgroundmusic5.SetActive(true);
            minimap.SetActive(false);
            mmpointer.SetActive(false);
            tunnelpointer.SetActive(true);
        }
    }
}