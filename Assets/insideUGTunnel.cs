using UnityEngine;public class insideUGTunnel:MonoBehaviour{
    public GameObject tunnelpointer,mmpointer, player, tunnel,mainmission4,minimap,backgroundmusic4,backgroundmusic5,DirectionalLight,mainmission2,mainmission3;
    public AudioSource ropesound;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {
            tunnel.SetActive(true);
            player.transform.position=new Vector3(224.548813f,191.06105f,-1056.89966f);
            player.transform.rotation=Quaternion.Euler(0,4.58604956f,0);
            ropesound.Play(); DirectionalLight.GetComponent<Light>().intensity=0;
            backgroundmusic4.SetActive(false);
            backgroundmusic5.SetActive(true);
            minimap.SetActive(false);            
            mainmission4.SetActive(true);
            mmpointer.SetActive(false);
            tunnelpointer.SetActive(true);mainmission2.SetActive(false); mainmission3.SetActive(false);
        }
    }
}