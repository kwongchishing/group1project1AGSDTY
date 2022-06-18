using UnityEngine;public class insideUGTunnel3:MonoBehaviour{
    public GameObject mmpointer,tunnelpointer,player,tunnel,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            tunnel.SetActive(true);
            player.transform.position=new Vector3(225.693497f,191.01593f,-1023.49463f);
            player.transform.rotation=Quaternion.Euler(0,186.612f,0);
            ropesound.Play();DirectionalLight.GetComponent<Light>().intensity=0;
            backgroundmusic4.SetActive(false);
            backgroundmusic5.SetActive(true);
            minimap.SetActive(false);
            mmpointer.SetActive(false);
            tunnelpointer.SetActive(true);
        }
    }
}