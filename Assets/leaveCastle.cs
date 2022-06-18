using UnityEngine;public class leaveCastle:MonoBehaviour{
    public GameObject player,backgroundmusic5,tunnel,prison,prisonbgm,tunnelpointer;
    public AudioSource opencastledoorSound;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
        {tunnel.SetActive(true);
            player.transform.position=new Vector3(227.596848f,210.566299f,-1050.11206f);
            player.transform.rotation=Quaternion.Euler(0,34.2814293f,0);
            opencastledoorSound.Play();prisonbgm.SetActive(false);
            backgroundmusic5.SetActive(true); prison.SetActive(false); tunnelpointer.SetActive(true);
        }
    }
}