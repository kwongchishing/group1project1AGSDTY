using UnityEngine;public class gooutUGTunnel2:MonoBehaviour{
    public GameObject tunnelpointer,mmpointer,player,tunnel,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight;
    public AudioSource ropesound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position=new Vector3(391.584167f,8.82023525f,379.891663f);
            ropesound.Play(); DirectionalLight.GetComponent<Light>().intensity=1.1f;
            backgroundmusic4.SetActive(true);
            backgroundmusic5.SetActive(false);
            tunnelpointer.SetActive(false);
            mmpointer.SetActive(true);
            minimap.SetActive(true); tunnel.SetActive(false);
        }
    }
}