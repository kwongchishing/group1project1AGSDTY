using UnityEngine;public class gooutUGTunnel4:MonoBehaviour{
    public GameObject tunnelpointer,mmpointer,player,tunnel,minimap,backgroundmusic1,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position=new Vector3(417.704529f,30.2246151f,290.455017f);
            ropesound.Play();DirectionalLight.GetComponent<Light>().intensity=1.1f;
            backgroundmusic1.SetActive(true);
            backgroundmusic5.SetActive(false);
            tunnelpointer.SetActive(false);
            mmpointer.SetActive(true);
            minimap.SetActive(true); tunnel.SetActive(false);
        }
    }
}