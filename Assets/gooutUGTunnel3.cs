using UnityEngine;public class gooutUGTunnel3:MonoBehaviour{
    public GameObject tunnelpointer,mmpointer,player,tunnel,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position=new Vector3(359.52298f,8.88887787f,392.723145f);
            ropesound.Play();DirectionalLight.GetComponent<Light>().intensity=1.1f;
            backgroundmusic4.SetActive(true);
            backgroundmusic5.SetActive(false);
            tunnelpointer.SetActive(false);
            mmpointer.SetActive(true);
            minimap.SetActive(true);tunnel.SetActive(false);
        }
    }
}