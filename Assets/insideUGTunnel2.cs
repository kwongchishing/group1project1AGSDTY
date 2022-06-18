using UnityEngine;public class insideUGTunnel2:MonoBehaviour{
    public GameObject tunnelpointer,mmpointer,player,tunnel,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            tunnel.SetActive(true);
            player.transform.position=new Vector3(234.967041f,191.018967f,-1043.56177f);
            player.transform.rotation=Quaternion.Euler(0,272.092529f,0);
            ropesound.Play(); DirectionalLight.GetComponent<Light>().intensity=0;
            backgroundmusic4.SetActive(false);
            backgroundmusic5.SetActive(true);
            minimap.SetActive(false);
            mmpointer.SetActive(false);
            tunnelpointer.SetActive(true);
        }
    }
}